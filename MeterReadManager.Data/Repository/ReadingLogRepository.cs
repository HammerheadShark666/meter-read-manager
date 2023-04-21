using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace MeterReadManager.Data.Repository;
public class ReadingLogRepository : BaseRepository, IReadingLogRepository
{
    public ReadingLogRepository(MeterReadManagerContext context) : base(context) { }
           
    public async Task<List<ReadingLogEntry?>> GetByMeterNumberAsync(string meterNumber)
    {
        return await (from rl in _context.ReadingLogs
                     join mtr in _context.Meters on rl.MeterId equals mtr.Id
                     where mtr.MeterNumber == meterNumber
                     orderby rl.DateTime descending
                     select new ReadingLogEntry()
                     {
                          MeterId = mtr.Id,
                          MeterNumber = mtr.MeterNumber,
                          DateTime = rl.DateTime,
                          MeterReadStatus = rl.MeterReadStatus,
                          StatusMessage = rl.StatusMessage
                     }).ToListAsync(); 
    }

    public async Task<List<ReadingLogEntry?>> GetByMeterNumberAndAccountIdAsync(string meterNumber, long accountId)
    {
        return await (from rl in _context.ReadingLogs
                      join mtr in _context.Meters on rl.MeterId equals mtr.Id
                      where mtr.MeterNumber == meterNumber && mtr.AccountId == accountId
                      orderby rl.DateTime descending
                      select new ReadingLogEntry()
                      {
                          MeterId = mtr.Id,
                          MeterNumber = mtr.MeterNumber,
                          DateTime = rl.DateTime,
                          MeterReadStatus = rl.MeterReadStatus,
                          StatusMessage = rl.StatusMessage
                      }).ToListAsync(); 
    }

    public void Add(ReadingLog readingLog)
    {
        _context.ReadingLogs.Add(readingLog);
    } 
}