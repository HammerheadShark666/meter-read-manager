using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;

namespace MeterReadManager.Business.Validator;

public class CountyValidator : BaseValidator<County>
{
    private readonly ICountyRepository _countyRepository; 

    public CountyValidator(ICountyRepository countyRepository)
    {
        _countyRepository = countyRepository; 

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
