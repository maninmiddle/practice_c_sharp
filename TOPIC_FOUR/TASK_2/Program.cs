using System;

class Program
{
  public static void Main()
  {
    double[] nums = { 1, 2, 3, 4, 5 };
    foreach (double n in nums) {
       PowerUtils.PowerA3(n, out double result);
       Console.WriteLine(result);
    }
  }
}
