namespace MeterReadManager.Helper.Interface;
public interface IDeserializeToObject<C>
{
    C? Deserialize(string data);
}