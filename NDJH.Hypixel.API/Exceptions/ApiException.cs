namespace NDJH.Hypixel.API.Exceptions;

public class ApiException : Exception
{
    public ApiException(int statusCode, string content)
        : base($"Server returned status code: {statusCode}. Response content: {content}")
    {
        StatusCode = statusCode;
        Content = content;
    }

    public int StatusCode { get; private set; }

    public string Content { get; private set; }
}