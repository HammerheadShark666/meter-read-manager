using Newtonsoft.Json;

namespace MeterReadManager.Domain.Dto;

public class MessageDto
{
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    [JsonProperty(PropertyName = "severity")]
    public string Severity { get; set; }

    public MessageDto() { }

    public MessageDto(string message, string serverity)
    {
        Message = message;
        Severity = serverity;
    }
}
