using MeterReadManager.Business.Validator;
using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;

namespace MeterReadManager.Business;

public class ReadingLogValidator : BaseValidator<ReadingLog>
{
    private readonly IReadingLogRepository _readingLogRepository;

    public ReadingLogValidator(IReadingLogRepository readingLogRepository)
    {
        _readingLogRepository = readingLogRepository;

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

