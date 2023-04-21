using MeterReadManager.Data.Repository;
using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Data.UnitOfWork.Interfaces;

namespace MeterReadManager.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MeterReadManagerContext _context;
  
    public IAccountRepository Accounts { get; private set; }
    public ICustomerRepository Customers { get; private set; }
    public ICountyRepository Counties { get; private set; }
    public IMeterReadingRepository MeterReadings { get; private set; }
    public IMeterRepository Meters { get; private set; }

    public IReadingLogRepository ReadingLogs { get; private set; }

    public UnitOfWork(MeterReadManagerContext context)
    {
        _context = context;         
        Accounts = new AccountRepository(_context);
        Counties = new CountyRepository(_context);
        Customers = new CustomerRepository(_context);
        Meters = new MeterRepository(_context);
        ReadingLogs = new ReadingLogRepository(_context);
        MeterReadings = new MeterReadingRepository(_context);
    }  

    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
    }
}