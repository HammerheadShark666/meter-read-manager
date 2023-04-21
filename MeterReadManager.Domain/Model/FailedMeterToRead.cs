namespace MeterReadManager.Domain.Model;

public class FailedMeterToRead
{
    public long MeterId { get; set; }
    public string MeterNumber { get; set; }   
    public DateTime DateTimeFailed { get; set; }
    public string FailedReason { get; set; }    
}
