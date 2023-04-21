using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace MeterReadManager.Data.Repository;
public class MeterReadingRepository : BaseRepository, IMeterReadingRepository
{     
    public MeterReadingRepository(MeterReadManagerContext context) : base(context) {}

    public void Add(MeterReading meterReading)
    {
        _context.MeterReadings.Add(meterReading);
    }

    public MeterReading? GetLastMeterReading(string meterNumber)
    {
        return (from meter in _context.Meters
                join meterReading in _context.MeterReadings on meter.Id equals meterReading.MeterId
                where meter.MeterNumber == meterNumber
                orderby meterReading.DateTime descending
                select meterReading).FirstOrDefault<MeterReading?>();
    }
}
