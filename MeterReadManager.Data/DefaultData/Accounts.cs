using MeterReadManager.Domain;
using static MeterReadManager.Domain.Helper.Enums;

namespace MeterReadManager.Data.DefaultData;
public class Accounts
{
    public static List<Account> GetAccountDefaultData()
    {
        return new List<Account>()
        {
            new Account {   Id = 1,
                            Title = "Mr",
                            FirstName = "Admin",
                            LastName = "Admin",
                            Email = "Admin@hotmail.com",
                            PasswordHash = "$2a$11$cHlJvvDHx8AZhGkRBJZCGeUYSbllmnU8y5B9JlB/hj/QxPwRjlOOq",
                            AcceptTerms = true,
                            Role = Role.Admin,
                            VerificationToken = "",
                            Verified = new DateTime(2023, 1, 1, 12, 39, 0),
                            ResetToken = "C3B17085E1C1371B8875D1374FB96F3450F33E072ABD0C964444E62C0CA855800A118C8C7E7146CE",
                            ResetTokenExpires = new DateTime(2023, 1, 1, 12, 39, 0),
                            PasswordReset = new DateTime(2023, 1, 1, 12, 39, 0),
                            Created = new DateTime(2023, 1, 1, 12, 39, 0)
                        },
            new Account {   Id = 2,
                            Title = "Mr",
                            FirstName = "Customer",
                            LastName = "Customer",
                            Email = "Customer@hotmail.com",
                            PasswordHash = "$2a$11$cHlJvvDHx8AZhGkRBJZCGeUYSbllmnU8y5B9JlB/hj/QxPwRjlOOq",
                            AcceptTerms = true,
                            Role = Role.Customer,
                            VerificationToken = "",
                            Verified = new DateTime(2023, 1, 1, 12, 39, 0),
                            ResetToken = "C3B17085E1C1371B8875D1374FB96F3450F33E072ABD0C964444E62C0CA855800A118C8C7E7146CE",
                            ResetTokenExpires = new DateTime(2023, 1, 1, 12, 39, 0),
                            PasswordReset = new DateTime(2023, 1, 1, 12, 39, 0),
                            Created = new DateTime(2023, 1, 1, 12, 39, 0)
                        }
        };
    }
}
