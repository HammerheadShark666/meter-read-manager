using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;

namespace MeterReadManager.Service.Interface;

public interface IReadingLogService
{
    Task<List<ReadingLogEntryDto>> GetAsync(string meterNumber, long accountId);

    Task SaveReadingLogAsync(ReadingLog readingLog);
}
