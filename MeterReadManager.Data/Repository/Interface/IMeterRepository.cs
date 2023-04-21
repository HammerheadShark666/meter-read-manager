using MeterReadManager.Domain;
using MeterReadManager.Domain.Model;

namespace MeterReadManager.Data.Repository.Interface;

public interface IMeterRepository
{
    void Add(Meter meter);
    void Update(Meter meter);
    Task<Meter?> ByIdAsync(int id);
    void Delete(Meter meter);
    Meter? GetByMeterNumber(string meterNumber);
    Task<Meter?> GetByMeterNumberAsync(string meterNumber);
    Task<Meter?> GetByMeterNumberAndAccountIdAsync(string meterNumber, long accountId);
    Task<List<MeterToRead>?> GetActiveMetersToReadAsync(int page, int pageSize);
    int GetActiveMetersToReadCount();
}
