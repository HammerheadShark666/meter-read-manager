using MeterReadManager.Domain;

namespace MeterReadManager.Data.Repository.Interface;

public interface IMeterReadingRepository
{
    void Add(MeterReading meterReading);

    MeterReading? GetLastMeterReading(string meterNumber);
}
