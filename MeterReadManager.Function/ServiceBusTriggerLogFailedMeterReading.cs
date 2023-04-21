using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Helper.Interface;
using MeterReadManager.Service;
using MeterReadManager.Service.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using MeterReadManager.Service.MeterReader;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Function
{
    public class ServiceBusTriggerLogFailedMeterReading : BaseMeterReader<FailedMeterToRead>
    {       
        private readonly IReadingLogService _readingLogService;
      
        public ServiceBusTriggerLogFailedMeterReading(ILogger<ServiceBusTriggerSaveMeterReading> logger,
                                                 IDeserializeToObject<FailedMeterToRead> deserializer,
                                                 IMeterReaderFailedMeterReadingService meterReaderFailedMeterReadingService2,
                                                 IReadingLogService readingLogService
                                                 ) : base(logger, deserializer, meterReaderFailedMeterReadingService2)
        {
            _readingLogService = readingLogService;
        }

        [Function("ServiceBusTriggerLogFailedMeterReading")]
        public async Task Run([ServiceBusTrigger($"%{Constants.AzureServiceBusQueueFailedMeterReadings}%", Connection = Constants.AzureServiceBusMeterReadingManagementConnectionString)] 
            string failedMeterReading,
            int deliveryCount)
        {
            FailedMeterToRead? failedMeterToRead = null;

            try
            {
                failedMeterToRead = _deserializer.Deserialize(failedMeterReading);
                if(failedMeterToRead != null) 
                    await _readingLogService.SaveReadingLogAsync(ReadingLogService.CreateReadingLog(failedMeterToRead.MeterId, failedMeterToRead.DateTimeFailed, false, failedMeterToRead.FailedReason));
                else
                    throw new Exception("Unable to deserialize failed meter reading");
            }
            catch (Exception ex)
            {
                if (failedMeterToRead != null)
                    await LogError(failedMeterToRead.MeterId, failedMeterToRead.MeterNumber, deliveryCount, ex.Message);

                _logger.LogInformation($"Failed meter log failed to save: {ex.Message}");
                throw;
            }
        }
    }
}