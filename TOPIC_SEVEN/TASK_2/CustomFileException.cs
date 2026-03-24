using System;

public class CustomFileException : Exception
{
    public CustomFileException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}