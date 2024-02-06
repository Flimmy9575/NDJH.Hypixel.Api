namespace NDJH.Hypixel.API.Exceptions;

public class ApiResponseNullException : Exception
{
    public ApiResponseNullException()
    {
    }

    public ApiResponseNullException(string message)
        : base(message)
    {
    }

    public ApiResponseNullException(string message, Exception inner)
        : base(message, inner)
    {
    }
}