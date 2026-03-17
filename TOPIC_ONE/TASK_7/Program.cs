using System;

class Program
{
   public static void Main()
   {
     Way1();
     Way2();
     Way3();
   }
   public static void Way1()
   {
	Console.WriteLine("Способ №1");
        int i = 1;
        while (i <= 101)
        {
            if (i > 1) Console.Write(" ");
            Console.Write(i);
            i += 2;
        }
        Console.WriteLine();
   }
   public static void Way2()
   {
	Console.WriteLine("Способ №2");
        int i = 1;
        do
        {
            if (i > 1) Console.Write(" ");
            Console.Write(i);
            i += 2;
        } while (i <= 101);
        Console.WriteLine();
   } 
   public static void Way3()
   {
	Console.WriteLine("Способ №3");
        for (int i = 1; i <= 101; i += 2)
        {
            if (i > 1) Console.Write(" ");
            Console.Write(i);
        }
        Console.WriteLine();
   }
}
