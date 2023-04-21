using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Helper.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using MeterReadManager.Service.MeterReader;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Function.ReadMeter;

public class ServiceBusTriggerReadMeter : BaseMeterReader<MeterToRead>
{  
    private readonly IMeterReaderReadMeterService _readMeterService; 

    public ServiceBusTriggerReadMeter(ILogger<ServiceBusTriggerReadMeter> logger,
                                      IDeserializeToObject<MeterToRead> deserializer,
                                      IMeterReaderFailedMeterReadingService meterReaderFailedMeterReadingService2,
                                      IMeterReaderReadMeterService meterReaderReadMeterService
                                      ) : base(logger, deserializer, meterReaderFailedMeterReadingService2)
    {
        _readMeterService = meterReaderReadMeterService;
    }
 
    [Function("ServiceBusTriggerReadMeter")]
    [ServiceBusOutput($"%{Constants.AzureServiceBusQueueMeterReadingsToSave}%", Connection = Constants.AzureServiceBusMeterReadingManagementConnectionString)]
    public async Task<string> Run([ServiceBusTrigger($"%{Constants.AzureServiceBusQueueMetersToRead}%", Connection = Constants.AzureServiceBusMeterReadingManagementConnectionString)] 
        string meter,
        int deliveryCount)
    {
        MeterToRead? meterToRead = null; 

        try
        {
            meterToRead = _deserializer.Deserialize(meter);
            if (meterToRead != null) 
                return _readMeterService.ReadMeter(meter);
            else           
                throw new Exception("Unable to deserialize meter to read");
        }
        catch (Exception ex)
        {
            if(meterToRead != null)
                await LogError(meterToRead.MeterId, meterToRead.MeterNumber, deliveryCount, ex.Message);

            _logger.LogInformation($"Meter failed to read: {ex.Message}");
            throw;
        } 
    }  
}