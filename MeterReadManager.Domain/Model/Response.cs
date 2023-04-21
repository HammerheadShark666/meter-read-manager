using AutoMapper;
using FluentValidation.Results;
using MeterReadManager.Domain.Dto;

namespace MeterReadManager.Domain.Model;

public class Response<T, D> where T : class, new()
                            where D : BaseDto
{
    public readonly IMapper _mapper;

    public Response(IMapper mapper)
    {
        _mapper = mapper;
    }

    public D ResponseDto(T entity, List<ValidationFailure> rules, bool isValid)
    {
        D dto = _mapper.Map<D>(entity);
        dto.Rules = rules;
        dto.IsValid = isValid;
        return dto;
    }
}
