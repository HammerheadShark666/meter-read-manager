using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain.Model.Authentication;

public class RegisterVerifyEmail
{        
    public string Token { get; set; }
}