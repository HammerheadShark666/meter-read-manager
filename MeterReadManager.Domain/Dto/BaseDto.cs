using FluentValidation;
using FluentValidation.Results;

namespace MeterReadManager.Domain.Dto;

public class BaseDto
{
    public List<MessageDto> Messages { get; set; }
    public bool IsValid { get; set; }

    public BaseDto()
    {
        Messages = new();
        IsValid = true;
    }

    public List<ValidationFailure> Rules
    {
        set
        {
            Messages = new();
            foreach (ValidationFailure validationFailure in value)
            {
                Messages.Add(new MessageDto() { Message = validationFailure.ErrorMessage, Severity = GetServerity(validationFailure.Severity) });
            }
        }
    }

    private string GetServerity(Severity severity)
    {
        return severity switch
        {
            Severity.Error => "error",
            Severity.Warning => "warning",
            Severity.Info => "info",
            _ => "",
        };
    }
}
