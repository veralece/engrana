namespace Engrana.DataTransfer;

public class ApiResult<T>
{
    public ApiResult() { }

    public ApiResult(T item)
    {
        if (item is not null)
        {
            Item = item;
        }
    }

    public T? Item { get; init; }
    public bool Successful { get; init; }
    public string? Message { get; init; }
}
