using MeterReadManager.Domain;

namespace MeterReadManager.Data.Repository.Interface;

public interface IAccountRepository
{
    Task<Account?> ByIdAsync(int id);
    Task<Account?> GetAsync(string email);
    Task<Account?> GetByResetTokenAsync(string resetToken);
    Task<Account?> GetByVerificationTokenAsync(string verificationToken);
    Task<Account?> GetByRefreshTokenAsync(string token);
    Task<bool> AccountExistsAsync(string email);
    Task<bool> AccountExistsAsync(string email, int id);
    Task<bool> AnyAccountExistAsync();
    Task<bool> ValidResetTokenAsync(string token);
    void Add(Account account);
    void Update(Account account);
    void Remove(Account account);
}
