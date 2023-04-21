using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;

namespace MeterReadManager.Service.Interface;

public interface IMeterReadingService
{
    Task<MeterReadingDto> SaveAsync(MeterReadingDto meterReadingDto);

    MeterReading? GetLastMeterReading(string meterNumber);
}
