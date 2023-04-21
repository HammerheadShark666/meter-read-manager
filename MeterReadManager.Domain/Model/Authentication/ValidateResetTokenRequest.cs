using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain.Model.Authentication;

public class ValidateResetTokenRequest
{
    [Required]
    public string Token { get; set; }
}