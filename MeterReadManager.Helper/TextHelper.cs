namespace MeterReadManager.Helper;

public class TextHelper
{
    public static string Base64Encode(string plainText)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    public static string Base64Decode(string plainText)
    {
        byte[] bytes = System.Convert.FromBase64String(plainText);
        return System.Text.Encoding.UTF8.GetString(bytes);
    }
}
