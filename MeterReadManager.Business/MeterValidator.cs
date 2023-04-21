using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;

namespace MeterReadManager.Business.Validator;

public class MeterValidator : BaseValidator<Meter>
{
    private readonly IMeterRepository _meterRepository; 

    public MeterValidator(IMeterRepository meterRepository)
    {
        _meterRepository = meterRepository; 

        RuleSet("BeforeSave", () => {
             
        });

        RuleSet("AfterSave", () => {
             
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => { 

        });        
    }
}
