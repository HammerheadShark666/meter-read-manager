using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain.Model.Authentication;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}