using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;

namespace MeterReadManager.Business.Validator;

public class AccountValidator : BaseValidator<Account>
{
    private readonly IAccountRepository _accountRepository;

    public AccountValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => { 

        });

        RuleSet("AfterSave", () => { 

        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => { 

        });

        RuleSet("GetAccount", () => {

        });
    }
}
