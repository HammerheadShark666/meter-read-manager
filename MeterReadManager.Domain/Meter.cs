using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain;

public class Meter
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Column(TypeName = "nvarchar(25)")]
    [Required]
    public string MeterNumber { get; set; }
#nullable enable
    [Column(TypeName = "nvarchar(250)")]
    public string? Location { get; set; }
#nullable disable
    public int MeterTypeId { get; set; }

    public bool Active { get; set; }

    public MeterType MeterType { get; set; }

    public long CustomerId { get; set; }

    public Customer Customer { get; set; }

    public long AccountId { get; set; }
}
