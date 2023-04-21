using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Helper;
using MeterReadManager.Service.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service;
public class MeterReadingService : BaseService<MeterReading, MeterReadingDto>, IMeterReadingService
{
    public MeterReadingService(IMapper mapper,
                               IValidator<MeterReading> validator,
                               IMemoryCache memoryCache,
                               IUnitOfWork unitOfWork) : base(validator, memoryCache, unitOfWork, mapper)
    { }

    public async Task<MeterReadingDto> SaveAsync(MeterReadingDto meterReadingDto)
    {
        MeterReading meterReading = GetMeterReading(meterReadingDto);         

        ValidationResult result = await BeforeSaveAsync(meterReading);
        if (!result.IsValid)
            return ResponseDto(meterReading, result.Errors, false);

        meterReading = await MapMeterIdToMeterReading(meterReading, meterReadingDto.MeterNumber);         
        meterReading = await SaveAsync(meterReading, CreateReadingLog(meterReading));

        return ResponseDto(meterReading, await AfterSaveAsync(meterReading), true);
    }

    private MeterReading GetMeterReading(MeterReadingDto meterReadingDto)
    {        
        return _mapper.Map<MeterReadingDto, MeterReading>(meterReadingDto, new MeterReading());
    }

    public MeterReading? GetLastMeterReading(string meterNumber)
    {        
        return _unitOfWork.MeterReadings.GetLastMeterReading(meterNumber);
    }

    private async Task<MeterReading> MapMeterIdToMeterReading(MeterReading meterReading, string meterNumber)
    {
        Meter? meter = await _unitOfWork.Meters.GetByMeterNumberAsync(meterNumber);
        
        if(meter != null)
            meterReading.MeterId = meter.Id;

        return meterReading;
    }

    private async Task<MeterReading> SaveAsync(MeterReading meterReading, ReadingLog readingLog)
    {         
        _unitOfWork.MeterReadings.Add(meterReading);
        _unitOfWork.ReadingLogs.Add(readingLog);
        await _unitOfWork.Complete();

        return meterReading;
    } 

    public ReadingLog CreateReadingLog(MeterReading meterReading) 
    {
        return new ()
        {
            MeterId = meterReading.MeterId,
            DateCreated = DateTime.Now,
            DateTime = meterReading.DateTime,
            MeterReadStatus = true,
            StatusMessage = Constants.MeterReadingLogStatus
        };
    }
}
