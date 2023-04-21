namespace MeterReadManager.Domain.Dto;

public class LoginDto : BaseDto
{        
    public string Email { get; set; }         
    public string Password { get; set; } 
    public bool IsAuthenticated { get; set; }
    public string JwtToken { get; set; }
    public string RefreshToken { get; set; } 
}