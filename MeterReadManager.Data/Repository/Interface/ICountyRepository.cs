using MeterReadManager.Domain;

namespace MeterReadManager.Data.Repository.Interface;

public interface ICountyRepository
{
    Task<List<County>> GetAllAsync();

    Task<County?> GetAsync(int id);

    Task<bool> FoundAsync(int id);
}
