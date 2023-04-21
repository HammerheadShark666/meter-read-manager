using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain;

public class Customer : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string Surname { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string FirstName { get; set; }

    [Column(TypeName = "nvarchar(250)")] 
    [Required]
    public string Email { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Address1 { get; set; }

#nullable enable
    [Column(TypeName = "nvarchar(100)")] 
    public string? Address2 { get; set; }

    [Column(TypeName = "nvarchar(100)")] 
    public string? Address3 { get; set; }
#nullable disable
    [Column(TypeName = "nvarchar(50)")]
    [Required]
    public string CityTown { get; set; }

    [Column(TypeName = "tinyint")]
    public int CountyId { get; set; }

    public County County { get; set; }

    [Column(TypeName = "nvarchar(20)")]
    [Required]
    public string Postcode { get; set; }
}
