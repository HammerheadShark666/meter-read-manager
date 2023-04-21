using MeterReadManager.Domain.Dto;

namespace MeterReadManager.Domain;

public class ReadingLogDto : BaseDto
{ 
    public string MeterNumber { get; set; }

    public long MeterId { get; set; }  

    public DateTime DateTime { get; set; }

    public Boolean MeterReadStatus { get; set; }

    public string StatusMessage { get; set; }   
}
