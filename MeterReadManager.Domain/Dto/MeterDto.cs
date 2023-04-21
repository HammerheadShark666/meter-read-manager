namespace MeterReadManager.Domain.Dto;

public class MeterDto : BaseDto
{
    public long Id { get; set; }
 
    public string MeterNumber { get; set; }
#nullable enable
    public string? Location { get; set; }
#nullable disable
    public int MeterTypeId { get; set; }

    public long CustomerId { get; set; }

    public long AccountId { get; set; }
}
