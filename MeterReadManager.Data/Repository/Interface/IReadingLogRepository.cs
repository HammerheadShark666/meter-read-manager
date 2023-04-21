using MeterReadManager.Domain;
using MeterReadManager.Domain.Model;

namespace MeterReadManager.Data.Repository.Interface;

public interface IReadingLogRepository
{
    void Add(ReadingLog readingLog);
    Task<List<ReadingLogEntry?>> GetByMeterNumberAsync(string meterNumber);
    Task<List<ReadingLogEntry?>> GetByMeterNumberAndAccountIdAsync(string meterNumber, long accountId);
}