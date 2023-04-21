using MeterReadManager.Domain.Dto;

namespace MeterReadManager.Service.Interface;

public interface IAccountService
{
    Task<AccountDto> SaveAsync(AccountDto accountDto);
}