using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Service.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service;

public class AccountService : BaseService<Account, AccountDto>, IAccountService
{
    private const string ErrorMessageAccountNotFound = "Account not found.";
    private const string EntityName = "Account";

    public AccountService(IMapper mapper,
                          IValidator<Account> validator,
                          IMemoryCache memoryCache,
                          IUnitOfWork unitOfWork) : base(validator, memoryCache, unitOfWork, mapper)
    { }

    public async Task<AccountDto> SaveAsync(AccountDto accountDto)
    { 
        Account? account = await GetAccountAsync(accountDto);

        if(account != null) { 

            ValidationResult result = await BeforeSaveAsync(account);
            if (!result.IsValid)
                return ResponseDto(account, result.Errors, false);

            account = await SaveAsync(account);

            return ResponseDto(account, await AfterSaveAsync(account), true);
        }

        return ResponseDto(new Account(), CreateValidationListMessage(EntityName, ErrorMessageAccountNotFound), false); 
    }

    private async Task<Account?> GetAccountAsync(AccountDto accountDto)
    {
        Account? currentAccount = accountDto.Id == 0 ? new() : await _unitOfWork.Accounts.ByIdAsync(accountDto.Id);
        return currentAccount == null ? null : _mapper.Map<AccountDto, Account>(accountDto, currentAccount); 
    }

    private async Task<Account> SaveAsync(Account account)
    {
        if (account.Id == 0)
            _unitOfWork.Accounts.Add(account);
        else
            _unitOfWork.Accounts.Update(account);

        await _unitOfWork.Complete();

        return account;
    }      
}
