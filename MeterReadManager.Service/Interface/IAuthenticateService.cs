using MeterReadManager.Domain.Dto;

namespace MeterReadManager.Service.Interface;

public interface IAuthenticateService
{
    Task<LoginDto> AuthenticateAsync(LoginDto loginDto, string ipAddress);
    Task<JwtRefreshTokenDto> RefreshTokenAsync(string token, string ipAddress);
}