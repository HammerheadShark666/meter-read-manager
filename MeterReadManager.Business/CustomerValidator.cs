using FluentValidation;
using MeterReadManager.Data.DefaultData;
using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Domain;

namespace MeterReadManager.Business.Validator;

public class CustomerValidator : BaseValidator<Customer>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ICountyRepository _countyRepository;

    public CustomerValidator(ICustomerRepository customerRepository, ICountyRepository countyRepository)
    {
        _customerRepository = customerRepository;
        _countyRepository = countyRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(customer => customer.Surname)
                    .NotEmpty().WithMessage("Customer surname is required.")
                    .Length(1, 50).WithMessage("Customer surname length between 1 and 50.");

            RuleFor(customer => customer.FirstName)
                    .NotEmpty().WithMessage("Customer first name is required.")
                    .Length(1, 50).WithMessage("Customer first name length between 1 and 50.");

            RuleFor(customer => customer.Email)
                    .NotEmpty().WithMessage("Customer email is required.")
                    .Length(4, 250).WithMessage("Customer email length between 4 and 250.");

            RuleFor(customer => customer.Address1)
                    .NotEmpty().WithMessage("Customer first address line is required.")
                    .Length(1, 100).WithMessage("Customer first address line length between 1 and 100.");

            RuleFor(customer => customer.CityTown)
                    .NotEmpty().WithMessage("Customer city/town is required.")
                    .Length(1, 50).WithMessage("Customer city/town length between 1 and 50.");

            RuleFor(customer => customer).MustAsync(async (customer, cancellation) => {
                return await CountyFoundAsync(customer.CountyId);
            }).WithMessage(artist => $"County not found.");


            RuleFor(customer => customer.Postcode)
                    .NotEmpty().WithMessage("Customer postcode is required.")
                    .Length(5, 7).WithMessage("Customer postcode length between 5 and 7.");

        });

        RuleSet("AfterSave", () => {

            RuleFor(customer => customer)
                   .Null()
                   .WithSeverity(Severity.Info)
                   .WithMessage("The customer has been saved.");
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => {

            RuleFor(customer => customer)
                    .Null()
                    .WithSeverity(Severity.Info)
                    .WithMessage("The customer has been deleted.");
        });        
    }
    protected async Task<bool> CountyFoundAsync(int countyId)
    {
        return await _countyRepository.FoundAsync(countyId);         
    }
}
