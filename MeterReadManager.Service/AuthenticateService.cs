using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Domain.Exceptions;
using MeterReadManager.Domain.Model.Authentication;
using MeterReadManager.Helper;
using MeterReadManager.Helpers;
using MeterReadManager.Service.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace MeterReadManager.Service
{
    public class AuthenticateService : BaseService<Login, LoginDto>, IAuthenticateService
    {
        private const string ExceptionMessageAuthenticateNotFound = "Login details not valid.";
        private const string EntityName = "Authenticate";

        public AuthenticateService(IMapper mapper,
                            IValidator<Login> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork) : base(validator, memoryCache, unitOfWork, mapper)
        {}

        public async Task<LoginDto> AuthenticateAsync(LoginDto loginDto, string ipAddress)
        {
            var login = _mapper.Map<Login>(loginDto);

            ValidationResult result = await BeforeSaveAsync(login);
            if (!result.IsValid)
                return ResponseDto(login, result.Errors, false);
             
            var account = await _unitOfWork.Accounts.GetAsync(loginDto.Email);

            if(account != null) { 
                var refreshToken = GenerateRefreshToken(account, ipAddress);
                account = await UpdateRefreshTokenAsync(account, ipAddress, refreshToken);             
                var jwtToken = AuthenticationHelper.GenerateJwtToken(account, EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes(), EnvironmentVariablesHelper.JwtSettingsSercret());

                return GetLoginDto(account, await AfterSaveAsync(login), true, jwtToken, refreshToken.Token);
            }

            return ResponseDto(new Login(), CreateValidationListMessage(EntityName, ExceptionMessageAuthenticateNotFound), false);
        } 

        private async Task<Account> UpdateRefreshTokenAsync(Account account, string ipAddress, RefreshToken refreshToken)
        {          
            RemoveOldRefreshTokens(account);
            account.RefreshTokens.Add(refreshToken);
            _unitOfWork.Accounts.Update(account);
            await _unitOfWork.Complete();

            return account;
        }

        public async Task<JwtRefreshTokenDto> RefreshTokenAsync(string token, string ipAddress)
        {
            var (RefreshToken, account) = await GetRefreshTokenAsync(token);
            var newRefreshToken = GetNewRefreshToken(ipAddress);

            RemoveOldRefreshTokens(account);
            account.RefreshTokens.Add(newRefreshToken);

            _unitOfWork.Accounts.Update(account);
            await _unitOfWork.Complete();

            var jwtToken = AuthenticationHelper.GenerateJwtToken(account, EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes(), EnvironmentVariablesHelper.JwtSettingsSercret());

            return CreateJwtRefreshTokenDto(account, jwtToken, newRefreshToken.Token);
        }

        private void RemoveOldRefreshTokens(Account account)
        {
            account.RefreshTokens.RemoveAll(x =>
                                    !x.IsActive &&
                                    x.Created.AddDays(EnvironmentVariablesHelper.JwtSettingsRefreshTokenTtl()) <= DateTime.Now);
        }

        private RefreshToken GenerateRefreshToken(Account account, string ipAddress)
        {
            var refreshTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsRefreshTokenExpiryDays());
            return AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);
        } 

        private RefreshToken GetNewRefreshToken(string ipAddress)
        {
            var refreshTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsRefreshTokenExpiryDays());
            return AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);
        }

        private async Task<(RefreshToken, Account)> GetRefreshTokenAsync(string token)
        {
            var account = await _unitOfWork.Accounts.GetByRefreshTokenAsync(token);
            if (account == null) 
                throw new AppException(ConstantMessages.InvalidToken);

            var refreshToken = account.RefreshTokens.Single(x => x.Token == token);
            if (!refreshToken.IsActive) 
                throw new AppException(ConstantMessages.InvalidToken);

            return (refreshToken, account);
        }

        public JwtRefreshTokenDto CreateJwtRefreshTokenDto(Account account, string jwtToken, string token)
        {
            var jwtRefreshTokenDto = _mapper.Map<JwtRefreshTokenDto>(account);                 
            jwtRefreshTokenDto.JwtToken = jwtToken;
            jwtRefreshTokenDto.RefreshToken = token;

            return jwtRefreshTokenDto;
        } 

        private LoginDto GetLoginDto(Account account, List<ValidationFailure> rules, bool isValid, string jwtToken, string refreshToken)
        {
            LoginDto loginDto = _mapper.Map<LoginDto>(account);
            loginDto.Rules = rules;
            loginDto.IsValid = isValid; 
            loginDto.JwtToken = jwtToken;
            loginDto.RefreshToken = refreshToken;  

            return loginDto;
        }
    }
}
