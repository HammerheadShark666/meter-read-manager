namespace MeterReadManager.Domain.Model.Paging;

public class BasePagedResponse<T>
{
    public BasePagedResponse()
    {
    }
    public BasePagedResponse(T data)
    {
        Succeeded = true;
        Message = string.Empty;
        Errors = new string[0];
        Data = data;
    }
    public T Data { get; set; }
    public bool Succeeded { get; set; }
    public string[] Errors { get; set; }
    public string Message { get; set; }
}
