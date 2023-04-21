using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeterReadManager.Domain;

public class County
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(TypeName = "tinyint")]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }

    public int CountryId { get; set; }

    public Country Country { get; set; } 
}
