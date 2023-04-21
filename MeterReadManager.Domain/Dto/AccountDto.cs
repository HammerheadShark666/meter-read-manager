using System.ComponentModel.DataAnnotations.Schema;

namespace MeterReadManager.Domain.Dto;

public class AccountDto : BaseDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public bool IsVerified { get; set; }
    public string Password { get; set; }         
    public string ConfirmPassword { get; set; }
    [NotMapped]
    public string CurrentPassword { get; set; }
}