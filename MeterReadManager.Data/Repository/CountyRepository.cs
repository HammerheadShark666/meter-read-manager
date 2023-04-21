using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace MeterReadManager.Data.Repository;

public class CountyRepository : BaseRepository, ICountyRepository
{
    public CountyRepository(MeterReadManagerContext context) : base(context) {}

    public async Task<List<County>> GetAllAsync()
    {
        return await _context.Counties
                             .OrderBy(x => x.Name)
                             .ToListAsync();                               
    }

    public async Task<County?> GetAsync(int id)
    {
        return await _context.Counties                            
                             .Where(c => c.Id == id)
                             .FirstOrDefaultAsync();
    }

    public async Task<bool> FoundAsync(int id)
    {
        return await _context.Counties
                             .Where(a => a.Id.Equals(id)).CountAsync() == 1;
    } 
}