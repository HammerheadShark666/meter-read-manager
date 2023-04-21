using MeterReadManager.Domain.Dto;

namespace MeterReadManager.Service.Interface;

public interface ICountyService
{
    Task<List<CountyDto>> GetAllAsync();
}
