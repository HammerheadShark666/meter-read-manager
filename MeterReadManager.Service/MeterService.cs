using AutoMapper;
using FluentValidation;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Domain.Model;
using MeterReadManager.Service.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service;

public class MeterService : BaseService<Meter, MeterDto>, IMeterService
{
    public MeterService(IMapper mapper,
                        IValidator<Meter> validator,
                        IMemoryCache memoryCache,
                        IUnitOfWork unitOfWork) : base(validator, memoryCache, unitOfWork, mapper)
    { }
    public async Task<Boolean> MeterBelongsToAccountAsync(string meterNumber, long accountId)
    {
        return await _unitOfWork.Meters.GetByMeterNumberAndAccountIdAsync(meterNumber, accountId) != null ? true : false;
    }

    public async Task<Boolean> MeterExists(string meterNumber) { 
    
        return await _unitOfWork.Meters.GetByMeterNumberAsync(meterNumber) != null ? true : false;
    }

    public async Task<List<MeterToRead>?> GetActiveMetersToReadAsync(int page, int pageSize)
    {
        return await _unitOfWork.Meters.GetActiveMetersToReadAsync(page, pageSize);
    }

    public int GetActiveMetersToReadCount()
    {
        return _unitOfWork.Meters.GetActiveMetersToReadCount();
    }

    public async Task<Meter?> GetMeterAsync(string meterNumber)
    {
        return await _unitOfWork.Meters.GetByMeterNumberAsync(meterNumber);
    }
}
