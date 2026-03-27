using System;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        logger1.Log("Application started.");
        logger1.Log("Processing user request.");

        Logger logger2 = Logger.Instance;
        logger2.Log("User data saved.");

        if (object.ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("logger1 and logger2 are the same instance.");
        }
        else
        {
            Console.WriteLine("logger1 and logger2 are different instances (this should not happen).");
        }

        logger1.ShowLogs();
        logger2.ShowLogs(); 

        logger1.Log("Application finished.");
        logger2.ShowLogs();
    }
}
