using MeterReadManager.Domain.Model;

namespace MeterReadManager.Service.Interface.MeterReader;

public interface IMeterReaderReadMeterSimulator
{
    SimulatedMeterReading SimulateReading(MeterToRead meterToRead);
}
