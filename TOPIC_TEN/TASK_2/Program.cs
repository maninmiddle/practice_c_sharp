using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== STRATEGY PATTERN ===\n");
        StrategyDemo.Run();

        Console.WriteLine("\n=== BUILDER PATTERN ===\n");
        BuilderDemo.Run();
    }
}
