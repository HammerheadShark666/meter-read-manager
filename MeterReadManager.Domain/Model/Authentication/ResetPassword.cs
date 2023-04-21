using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain.Model.Authentication;

public class ResetPassword
{        
    public string Token { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword { get; set; }
}