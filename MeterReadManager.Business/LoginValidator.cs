using FluentValidation;
using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain.Model.Authentication;
using BC = BCrypt.Net.BCrypt;

namespace MeterReadManager.Business.Validator;

public class LoginValidator : BaseValidator<Login>
{
    private readonly IAccountRepository _accountRepository;
     
    public LoginValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(login => login.Email)
                .NotEmpty().WithMessage("Email is required.")
                .Length(8, 150).WithMessage("Email length between 8 and 150.")
                .EmailAddress().WithMessage("Invalid Email.");

            RuleFor(login => login.Password)
                .NotEmpty().WithMessage("Password is required.")
                .Length(8, 50).WithMessage("Password length between 8 and 50.");
              
            RuleFor(login => login).MustAsync(async (login, cancellation) => {
                return await ValidLoginDetails(login);
            }).WithMessage("Invalid login");
        });

        RuleSet("AfterSave", () => {

            RuleFor(register => register)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage("Login successful");
        }); 
    }

    protected async Task<bool> ValidLoginDetails(Login login)
    {
        var account = await _accountRepository.GetAsync(login.Email);
        if (account == null || !account.IsAuthenticated || !BC.Verify(login.Password, account.PasswordHash))
            return false;

        return true;          
    }                    
}