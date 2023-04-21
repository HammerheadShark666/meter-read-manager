using AutoMapper;
using FluentValidation;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Service.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service;

public class ReadingLogService : BaseService<ReadingLog, ReadingLogDto>, IReadingLogService
{
    public ReadingLogService(IMapper mapper,
                             IValidator<ReadingLog> validator,
                             IMemoryCache memoryCache,
                             IUnitOfWork unitOfWork) : base(validator, memoryCache, unitOfWork, mapper)
    { }

    public async Task<List<ReadingLogEntryDto>> GetAsync(string meterNumber, long accountId)
    {
        return _mapper.Map<List<ReadingLogEntryDto>>(await _unitOfWork.ReadingLogs.GetByMeterNumberAndAccountIdAsync(meterNumber, accountId));
    }

    public async Task SaveReadingLogAsync(ReadingLog readingLog)
    {
        _unitOfWork.ReadingLogs.Add(readingLog);
        await _unitOfWork.Complete();        
    } 

    public static ReadingLog CreateReadingLog(long meterId, DateTime dateTime, bool status, string statusMessage)
    {
        return new ReadingLog()
        {
            MeterId = meterId,
            DateTime = dateTime,
            DateCreated = DateTime.Now,
            MeterReadStatus = status,
            StatusMessage = statusMessage
        };
    }
}
