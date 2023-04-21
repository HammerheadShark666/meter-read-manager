namespace MeterReadManager.Domain.Dto;

public class ReadingLogEntryDto
{
    public string MeterNumber { get; set; }

    public DateTime DateTime { get; set; }

    public Boolean MeterReadStatus { get; set; }

    public string StatusMessage { get; set; }
}
