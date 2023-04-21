namespace MeterReadManager.Domain;

public class BaseEntity
{
    public DateTime AddedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public BaseEntity()
    {
        AddedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;
    }
}
