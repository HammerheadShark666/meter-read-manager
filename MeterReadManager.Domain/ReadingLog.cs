using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain;

public class ReadingLog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public long MeterId { get; set; }   

    public Meter Meter { get; set; }

    public DateTime DateTime { get; set; }

    public DateTime DateCreated { get; set; }

    public Boolean MeterReadStatus { get; set; }

    public string StatusMessage { get; set; }   
}
