using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Helper.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using MeterReadManager.Service.MeterReader;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Function
{
    public class ServiceBusTriggerSaveMeterReading : BaseMeterReader<SimulatedMeterReading>
    { 
        private readonly IMeterReaderSaveMeterReadingService _meterReaderSaveMeterReadingService;    

        public ServiceBusTriggerSaveMeterReading(ILogger<ServiceBusTriggerSaveMeterReading> logger,
                                                 IDeserializeToObject<SimulatedMeterReading> deserializer,
                                                 IMeterReaderFailedMeterReadingService meterReaderFailedMeterReadingService2,
                                                 IMeterReaderSaveMeterReadingService meterReaderSaveMeterReadingService          
                                                 ) : base(logger, deserializer, meterReaderFailedMeterReadingService2)
        {
            _meterReaderSaveMeterReadingService = meterReaderSaveMeterReadingService;
        } 

        [Function("ServiceBusTriggerSaveMeterReading")]
        public async Task Run([ServiceBusTrigger($"%{Constants.AzureServiceBusQueueMeterReadingsToSave}%", Connection = Constants.AzureServiceBusMeterReadingManagementConnectionString)] 
            string meterReading,
            int deliveryCount)
        {
            SimulatedMeterReading? simulatedMeterReading = null;

            try
            {
                simulatedMeterReading = _deserializer.Deserialize(meterReading);
                if (simulatedMeterReading != null) 
                    await _meterReaderSaveMeterReadingService.SaveMeterReadingAsync(simulatedMeterReading);                 
                else 
                    throw new Exception("Unable to deserialize simulated meter reading");  
            }
            catch (Exception ex)
            {
                if (simulatedMeterReading != null)
                    await LogError(simulatedMeterReading.MeterId, simulatedMeterReading.MeterNumber, deliveryCount, ex.Message); 

                _logger.LogInformation($"Meter failed to save: {ex.Message}");
                throw;
            }
        } 
    }
}