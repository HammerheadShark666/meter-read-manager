using MeterReadManager.Helper.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Service.MeterReader;

public class BaseMeterReader<T> where T : class, new()
{    
    public readonly ILogger _logger;
    public readonly IDeserializeToObject<T> _deserializer;
    public readonly IMeterReaderFailedMeterReadingService _meterReaderFailedMeterReadingService;

    public BaseMeterReader(ILogger logger, IDeserializeToObject<T> deserializer, IMeterReaderFailedMeterReadingService meterReaderFailedMeterReadingService)
    { 
        _logger = logger;
        _deserializer = deserializer;
        _meterReaderFailedMeterReadingService = meterReaderFailedMeterReadingService;
    }

    public async Task LogError(long meterId, string meterNumber, int deliveryCount, string message)
    {       
        await _meterReaderFailedMeterReadingService.LogFailedMeterReading(deliveryCount, meterId, meterNumber, message);       
    }     
}
