using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Helper;
using MeterReadManager.Service.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service;

public class CustomerService : BaseService<Customer, CustomerDto>, ICustomerService
{
    private const string ExceptionMessageCustomerNotFound = "Customer not found.";
    private const string EntityName = "Customer";

    public CustomerService(IMapper mapper,
                           IValidator<Customer> validator,
                           IMemoryCache memoryCache,
                           IUnitOfWork unitOfWork) : base(validator, memoryCache, unitOfWork, mapper)
    { }

    public async Task<CustomerDto> GetAsync(long id)
    {
        Customer? customer = await _unitOfWork.Customers.GetAsync(id);

        return customer != null ? _mapper.Map<CustomerDto>(customer)
                                : ResponseDto(new Customer(), CreateValidationListMessage(EntityName, ExceptionMessageCustomerNotFound), false);


        //if (customer != null)         
        //    return _mapper.Map<CustomerDto>(customer);         

        //return ResponseDto(new Customer(), CreateValidationListMessage(EntityName, ExceptionMessageCustomerNotFound), false);
    }

    public async Task<List<CustomerDto>> GetAsync(PaginationFilter filter)
    {
        return _mapper.Map<List<CustomerDto>>(await _unitOfWork.Customers.GetAllAsync(filter.PageNumber, filter.PageSize)).OrderBy(a => a.Surname).ToList();
    }

    public async Task<long> CountAsync()
    {
        return await _unitOfWork.Customers.CountAsync();
    }

    public async Task<CustomerDto> SaveAsync(CustomerDto customerDto)
    {
        Customer? customer = await GetCustomerAsync(customerDto);

        if (customer != null)
        {
            ValidationResult result = await BeforeSaveAsync(customer);
            if (!result.IsValid)
                return ResponseDto(customer, result.Errors, false);

            customer = await SaveAsync(customer);

            return ResponseDto(customer, await AfterSaveAsync(customer), true);
        }

        return ResponseDto(new Customer(), CreateValidationListMessage(EntityName, ExceptionMessageCustomerNotFound), false);
    }

    private async Task<Customer?> GetCustomerAsync(CustomerDto customerDto)
    {
        Customer? customer = customerDto.Id == 0 ? new() : await _unitOfWork.Customers.GetAsync(customerDto.Id);
        return customer == null ? null : _mapper.Map<CustomerDto, Customer>(customerDto, customer); 
    }

    private async Task<Customer> SaveAsync(Customer customer)
    {
        if (customer.Id == 0)
            _unitOfWork.Customers.Add(customer);
        else
            _unitOfWork.Customers.Update(customer);

        await _unitOfWork.Complete();

        return customer;
    }

    public async Task<CustomerDto> DeleteAsync(long id)
    {
        Customer? customer = await _unitOfWork.Customers.GetAsync(id);

        if (customer != null)
        {
            ValidationResult result = await BeforeDeleteAsync(customer);
            if (!result.IsValid)
                return ResponseDto(customer, result.Errors, false);

            customer = await DeleteAsync(customer);

            return ResponseDto(customer, await AfterDeleteAsync(customer), true);
        }

        return ResponseDto(new Customer(), CreateValidationListMessage(EntityName, ExceptionMessageCustomerNotFound), false);
    }

    private async Task<Customer> DeleteAsync(Customer customer)
    {
        _unitOfWork.Customers.Remove(customer);
        await _unitOfWork.Complete();

        return customer;
    }
}