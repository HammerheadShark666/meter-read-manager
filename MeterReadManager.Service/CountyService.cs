using AutoMapper;
using FluentValidation;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Helper;
using MeterReadManager.Service.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service;

public class CountyService : BaseService<County, CountyDto>, ICountyService
{
    public CountyService(IMapper mapper,
                         IValidator<County> validator,
                         IMemoryCache memoryCache,
                         IUnitOfWork unitOfWork) : base(validator, memoryCache, unitOfWork, mapper)
    { }

    public async Task<List<CountyDto>> GetAllAsync()
    {
        return _mapper.Map<List<CountyDto>>(await _unitOfWork.Counties.GetAllAsync()).OrderBy(a => a.Name).ToList();
    }
}
