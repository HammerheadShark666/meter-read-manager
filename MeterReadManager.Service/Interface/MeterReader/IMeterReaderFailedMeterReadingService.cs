namespace MeterReadManager.Service.Interface.MeterReader;

public interface IMeterReaderFailedMeterReadingService
{
    Task LogFailedMeterReading(int deliveryCount, long meterId, string meterNumber, string failedReason);
}
