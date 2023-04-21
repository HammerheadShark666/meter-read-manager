using Azure;
using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MeterReadManager.Data.Repository;
public class MeterRepository : BaseRepository, IMeterRepository
{
    public MeterRepository(MeterReadManagerContext context) : base(context) { }
           
    public async Task<Meter?> GetByMeterNumberAsync(string meterNumber)
    {
        return await _context.Meters
                            .Where(c => c.MeterNumber == meterNumber)
                            .FirstOrDefaultAsync();
    }

    public Meter? GetByMeterNumber(string meterNumber)
    {
        return _context.Meters
                            .Where(c => c.MeterNumber == meterNumber)
                            .FirstOrDefault();
    }

    public async Task<Meter?> GetByMeterNumberAndAccountIdAsync(string meterNumber, long accountId)
    {
        return await _context.Meters
                            .Where(c => c.MeterNumber == meterNumber && c.AccountId == accountId)
                            .FirstOrDefaultAsync();
    }

    public void Add(Meter meter)
    {
        _context.Meters.Add(meter);
    }

    public void Update(Meter meter)
    {
        _context.Meters.Update(meter);
    }     

    public async Task<Meter?> ByIdAsync(int id)
    {
        return await _context.Meters
                            .Where(c => c.Id == id)
                            .FirstOrDefaultAsync();
    }

    public void Delete(Meter meter)
    {
        _context.Meters.Remove(meter);
    }

    public async Task<List<MeterToRead>?> GetActiveMetersToReadAsync(int page, int pageSize)
    {
        return await _context.Meters
                            .Where(c => c.Active == true)
                            .Skip((page - 1) * pageSize)
                            .Take(pageSize)
                            .OrderBy(c => c.MeterNumber)
                            .Select(c => new MeterToRead()
                            {
                                MeterId = c.Id,
                                MeterNumber = c.MeterNumber,
                                MeterTypeId = c.MeterTypeId
                            })
                            .ToListAsync<MeterToRead>();
    }

    public async Task<List<MeterToRead>?> GetActiveMetersToReadAsync()
    {
        return await _context.Meters
                            .Where(c => c.Active == true)
                            .Select(c => new MeterToRead()
                            {
                                MeterId = c.Id,
                                MeterNumber = c.MeterNumber,
                                MeterTypeId = c.MeterTypeId
                            })
                            .ToListAsync<MeterToRead>();
    }

    public int GetActiveMetersToReadCount()
    {
        return _context.Meters
                    .Where(c => c.Active == true)
                    .Count(); 
    }
}