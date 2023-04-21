using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace MeterReadManager.Data.Repository;

public class CustomerRepository : BaseRepository, ICustomerRepository
{  
    public CustomerRepository(MeterReadManagerContext context) : base(context) {}

    public async Task<Customer?> GetAsync(long id)
    {
        return await _context.Customers
                            .Include(e => e.County).ThenInclude(t => t.Country)
                            .Where(c => c.Id == id)
                            .FirstOrDefaultAsync();     
    }

    public async Task<List<Customer>> GetAllAsync(int pageNumber, int pageSize)
    {

        return await _context.Customers
                             .OrderBy(a => a.Surname)
                             .Skip((pageNumber - 1) * pageSize)
                             .Take(pageSize)
                             .ToListAsync();
    }

    public async Task<long> CountAsync()
    {
        return await _context.Customers.CountAsync();
    }

    public void Add(Customer customer)
    {
        _context.Customers.Add(customer);
    }

    public void Update(Customer customer)
    {
        _context.Customers.Update(customer);
    }

    public void Remove(Customer customer)
    {
        _context.Customers.Remove(customer);
    }
}