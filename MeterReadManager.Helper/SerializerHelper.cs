using Newtonsoft.Json;

namespace MeterReadManager.Helper;

public class SerializerHelper
{
    public static string Serialize(object objectToSerialize)
    {
        return TextHelper.Base64Encode(JsonConvert.SerializeObject(objectToSerialize));
    } 
}
