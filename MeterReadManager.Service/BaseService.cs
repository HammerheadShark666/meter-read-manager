using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service;

public class BaseService<T, D>  : Response<T, D> where T : class, new()
                                                 where D : BaseDto  
{        
    private readonly IValidator<T> _validator;
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork; 
     
    public BaseService(IValidator<T> validator, IMemoryCache memoryCache, IUnitOfWork unitOfWork, IMapper mapper) : base(mapper)
    {
        _validator = validator;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork; 
    }

    public void Dispose()
    {
        _unitOfWork.Dispose();
    }

    public async Task<ValidationResult> BeforeSaveAsync(T item)
    {
        return await _validator.ValidateAsync(item, options => options
                                    .IncludeRuleSets("BeforeSave"));
    }

    public async Task<List<FluentValidation.Results.ValidationFailure>> AfterSaveAsync(T item, string cacheKey)
    {
        if (cacheKey != null)
            _memoryCache.Remove(cacheKey);

        var afterSaveRules = await _validator.ValidateAsync(item, options => options
                                    .IncludeRuleSets("AfterSave")); 

        return afterSaveRules.Errors.Count > 0 ? afterSaveRules.Errors : new();
    }

    public async Task<List<FluentValidation.Results.ValidationFailure>> AfterSaveAsync(T item)
    {
        var afterSaveRules = await _validator.ValidateAsync(item, options => options
                                    .IncludeRuleSets("AfterSave"));

        return afterSaveRules.Errors.Count > 0 ? afterSaveRules.Errors : new();
    }

    public async Task<ValidationResult> BeforeDeleteAsync(T item)
    {
        return await _validator.ValidateAsync(item, options => options
                                    .IncludeRuleSets("BeforeDelete"));
    }

    public async Task<List<ValidationFailure>> AfterDeleteAsync(T item, string cacheKey)
    {
        if (cacheKey != null)
            _memoryCache.Remove(cacheKey);

        var afterDeleteRules = await _validator.ValidateAsync(item, options => options
                                    .IncludeRuleSets("AfterDelete"));

        return (afterDeleteRules != null && afterDeleteRules.Errors.Count > 0) ? afterDeleteRules.Errors : new();
    }

    public async Task<List<ValidationFailure>> AfterDeleteAsync(T item)
    {
        var afterDeleteRules = await _validator.ValidateAsync(item, options => options
                                    .IncludeRuleSets("AfterDelete"));

        return (afterDeleteRules != null && afterDeleteRules.Errors.Count > 0) ? afterDeleteRules.Errors : new();
    }

    public void Send(string email, string subject, string html)
    {
        SendGridEmailHelper.SendEmail(email, subject, $@"{html}");
    } 

    public T GetEntity(T entity)
    {
        return entity ?? new T();
    }

    public List<ValidationFailure> CreateValidationListMessage(string entityName, string message)
    {
        List<ValidationFailure> validationFailures = new List<ValidationFailure>
        {
            new ValidationFailure(entityName, message)
        };
        return validationFailures;
    } 
}
