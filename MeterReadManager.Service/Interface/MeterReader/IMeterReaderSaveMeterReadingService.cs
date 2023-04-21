using MeterReadManager.Domain.Model;

namespace MeterReadManager.Service.Interface.MeterReader;

public interface IMeterReaderSaveMeterReadingService
{
    Task SaveMeterReadingAsync(SimulatedMeterReading simulatedMeterReading);
}
