using System;

class Program 
{
   public static void Main()
   {
      Console.WriteLine($"Factorial: {MathUtils.Factorial(5)}");
      Console.WriteLine($"Factorial рекурсией: {MathUtils.FactorialRecursive(5)}");
   }
}
