namespace MeterReadManager.Domain.Dto;

public class CountyDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Country Country { get; set; }
}
