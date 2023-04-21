using FluentValidation;
using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;

namespace MeterReadManager.Business.Validator;

public class MeterReadingValidator : BaseValidator<MeterReading>
{
    private readonly IMeterRepository _meterRepository; 

    public MeterReadingValidator(IMeterRepository meterRepository)
    {
        _meterRepository = meterRepository; 

        RuleSet("BeforeSave", () => {

            RuleFor(meterReading => meterReading).MustAsync(async (meterReading, cancellation) => {
                return await MeterFoundAsync(meterReading.MeterNumber);
            }).WithMessage(artist => $"Meter not found.");

            RuleFor(meterReading => meterReading).MustAsync(async (meterReading, cancellation) => {
                return await MeterBelongsToAccountAsync(meterReading.MeterNumber, meterReading.AccountId);
            }).WithMessage(artist => $"Meter is not in account.");
        });

        RuleSet("AfterSave", () => {

            RuleFor(meterReading => meterReading)
                  .Null()
                  .WithSeverity(Severity.Info)
                  .WithMessage("The meter reading has been saved.");
        });        
    }

    protected async Task<bool> MeterFoundAsync(string meterNumber)
    {
        return await _meterRepository.GetByMeterNumberAsync(meterNumber) != null;
    }

    protected async Task<bool> MeterBelongsToAccountAsync(string meterNumber, long accountId)
    {
        return await _meterRepository.GetByMeterNumberAndAccountIdAsync(meterNumber,accountId) != null;
    }     
}
