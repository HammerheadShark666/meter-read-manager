using MeterReadManager.Domain;

namespace MeterReadManager.Data.Repository.Interface;

public interface ICustomerRepository
{
    Task<Customer?> GetAsync(long id);
    Task<List<Customer>> GetAllAsync(int pageNumber, int pageSize);
    Task<long> CountAsync();
    void Add(Customer customer);
    void Update(Customer customer);
    void Remove(Customer customer);
}
