using MeterReadManager.Domain.Dto;
using MeterReadManager.Helper;

namespace MeterReadManager.Service.Interface;

public interface ICustomerService
{
    Task<CustomerDto> GetAsync(long id);

    Task<List<CustomerDto>> GetAsync(PaginationFilter filter);

    Task<long> CountAsync();

    Task<CustomerDto> SaveAsync(CustomerDto customerDto);

    Task<CustomerDto> DeleteAsync(long id);
}
