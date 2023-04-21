namespace MeterReadManager.Domain.Model;
public class MeterReadingToSave
{
    public long MeterId { get; set; }
    public string MeterNumber { get; set; }

    public double Reading { get; set; }

    public DateTime ReadingDateTime { get; set; }
}
