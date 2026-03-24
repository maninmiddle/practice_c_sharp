using System;

public class AgeRestrictionException : Exception
{
    public AgeRestrictionException(string message)
        : base(message)
    {
    }
}