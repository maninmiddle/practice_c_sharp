static class MathUtils
{
  public static long Factorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    public static long FactorialRecursive(int n)
    {
        if (n <= 1) return 1;
        return n * FactorialRecursive(n - 1);
    }
}
