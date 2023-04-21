using MeterReadManager.Data.Repository.Interface;

namespace MeterReadManager.Data.UnitOfWork.Interfaces;

public interface IUnitOfWork : IDisposable
{    
    IAccountRepository Accounts { get; }
    ICustomerRepository Customers { get; }
    ICountyRepository Counties { get; }
    IMeterReadingRepository MeterReadings { get; }
    IMeterRepository Meters { get; }
    IReadingLogRepository ReadingLogs { get; }
    Task<int> Complete();
}