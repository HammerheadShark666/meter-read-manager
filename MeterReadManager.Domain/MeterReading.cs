using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MeterReadManager.Domain;

public class MeterReading
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    public DateTime DateTime { get; set; }

    [Precision(18, 2)]
    public Decimal Value { get; set; }
 
    public long MeterId { get; set; } 

    [NotMapped]
    public string MeterNumber { get; set; }

    [NotMapped]
    public long AccountId { get; set; }
}
