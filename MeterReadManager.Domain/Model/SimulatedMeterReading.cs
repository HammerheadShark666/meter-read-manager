namespace MeterReadManager.Domain.Model;
public class SimulatedMeterReading
{
    public long MeterId { get; set; }

    public string MeterNumber { get; set; }

    public decimal Value { get; set; }

    public DateTime DateTime { get; set; }
}
