namespace MeterReadManager.Domain.Model;

public class ReadingLogEntry
{
    public long MeterId { get; set; }

    public string MeterNumber { get; set; }

    public DateTime DateTime { get; set; }

    public Boolean MeterReadStatus { get; set; }

    public string StatusMessage { get; set; }
}
