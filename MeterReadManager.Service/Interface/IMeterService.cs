using MeterReadManager.Domain;
using MeterReadManager.Domain.Model;

namespace MeterReadManager.Service.Interface;

public interface IMeterService
{
    Task<Boolean> MeterBelongsToAccountAsync(string meterNumber, long accountId);
    Task<Boolean> MeterExists(string meterNumber);
    Task<List<MeterToRead>?> GetActiveMetersToReadAsync(int page, int pageSize);
    int GetActiveMetersToReadCount();
    Task<Meter?> GetMeterAsync(string meterNumber);
}
