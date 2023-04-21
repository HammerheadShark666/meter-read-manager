using Azure.Messaging.ServiceBus;
using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Service.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Service.MeterReader;

public class MeterReaderFailedMeterReadingService : IMeterReaderFailedMeterReadingService
{
    private readonly ILogger _logger; 
    private readonly IReadingLogService _readingLogService; 

    public MeterReaderFailedMeterReadingService(ILoggerFactory loggerFactory, IReadingLogService readingLogService)
    {
        _logger = loggerFactory.CreateLogger<MeterReaderFailedMeterReadingService>();
        _readingLogService = readingLogService; 
    }

    public async Task LogFailedMeterReading(int deliveryCount, long meterId, string meterNumber, string failedReason)
    {
        if (deliveryCount == 10)
        {           
            await using var client = new ServiceBusClient(EnvironmentVariablesHelper.AzureServiceBusMeterReadingManagementConnectionString());
            ServiceBusSender sender = client.CreateSender(EnvironmentVariablesHelper.AzureServiceBusQueueFailedMeterReadings());
            ServiceBusMessage message = new ServiceBusMessage(SerializerHelper.Serialize(CreateFailedMeterToRead(deliveryCount, meterId, meterNumber, failedReason)));
            await sender.SendMessageAsync(message);            
        }
    } 

    private FailedMeterToRead CreateFailedMeterToRead(int deliveryCount, long meterId, string meterNumber, string failedReason)
    {
        return new FailedMeterToRead()
        {
            MeterId = meterId,
            MeterNumber = meterNumber,
            FailedReason = $"{failedReason} - Attempted({deliveryCount})",
            DateTimeFailed = DateTime.Now
        }; 
    }
}
