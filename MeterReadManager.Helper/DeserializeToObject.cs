using MeterReadManager.Helper.Interface;

namespace MeterReadManager.Helper;

public class DeserializeToObject<C> : IDeserializeToObject<C> where C : class
{
    public C? Deserialize(string data)
    {
        C? deserializedObject = default;

        try
        {
            string json = TextHelper.Base64Decode(data);
            if (json != null)
                deserializedObject = System.Text.Json.JsonSerializer.Deserialize<C>(json);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to deserialize. {ex.Message}");
        }

        return deserializedObject;
    }
}