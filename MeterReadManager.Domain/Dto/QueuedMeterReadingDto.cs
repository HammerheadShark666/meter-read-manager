namespace MeterReadManager.Domain.Dto;

public class QueuedMeterReadingDto 
{
    public string MeterNumber { get; set; }
    public DateTime DateTime { get; set; } 
    public Decimal Value { get; set; } 
}
