namespace MeterReadManager.Domain.Dto;

public class MeterReadingDto : BaseDto
{
    public string MeterNumber { get; set; }
    public DateTime DateTime { get; set; } 
    public Decimal Value { get; set; }

    public long AccountId { get; set; }
}
