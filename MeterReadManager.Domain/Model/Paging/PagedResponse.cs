using System;

namespace MeterReadManager.Domain.Model.Paging;

public class PagedResponse<T> : BasePagedResponse<T>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }        
    public int TotalPages { get; set; }
    public long TotalRecords { get; set; } 
    public PagedResponse(T data, int pageNumber, int pageSize)
    {
        this.PageNumber = pageNumber;
        this.PageSize = pageSize;
        this.Data = data;
        this.Message = null;
        this.Succeeded = true;
        this.Errors = null;
    }
}
