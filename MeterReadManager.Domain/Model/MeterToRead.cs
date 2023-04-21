namespace MeterReadManager.Domain.Model;

public class MeterToRead
{
    public long MeterId { get; set; }
    public string MeterNumber { get; set; }  
    public int MeterTypeId { get; set; }
}
