using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Service.Interface.MeterReader;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Function.MetersToRead;

public class TimerTriggerMetersToRead
{
    private readonly ILogger _logger; 
    private readonly IMeterReaderMetersToReadService _meterReaderMetersToReadService;
    public TimerTriggerMetersToRead(ILoggerFactory loggerFactory, IMeterReaderMetersToReadService meterReaderMetersToReadService)
    {
        _logger = loggerFactory.CreateLogger<TimerTriggerMetersToRead>();
        _meterReaderMetersToReadService = meterReaderMetersToReadService;
    }

    [Function("TimerTriggerScheduleMetersToRead")]
    public async Task Run([TimerTrigger($"%{Constants.AzureTriggerTimerMetersToRead}%", RunOnStartup = false, UseMonitor = false)] MyInfo myInfo)
    {
        try
        {
            //Log that this trigger started

            await _meterReaderMetersToReadService.PutMetersToReadOnServiceBusQueue();

            //Log that this trigger ended
        }
        catch (Exception ex)
        {
            //Log that this trigger failed
            _logger.LogInformation($"Error: {ex}");
            throw;
        }
    }
} 