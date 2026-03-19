using System;

class Program 
{
   public static void Main()
   {
      Person[] people = ArrayUtils.GenerateSampleData();

      Console.WriteLine("Исходный массив:");
      foreach (var p in people)
         Console.WriteLine(p);

      Console.WriteLine($"\nМаксимальный возраст: {ArrayUtils.GetMaxValue(people)}");
      Console.WriteLine($"Средний возраст: {ArrayUtils.GetAverageAge(people):F2}");

      Console.WriteLine("\nСовершеннолетние:");
      Person[] adults = ArrayUtils.FilterAdults(people);
      foreach (var p in adults)
         Console.WriteLine(p);

      ArrayUtils.SortByAge(people);
      Console.WriteLine("\nПосле сортировки по возрасту:");
      foreach (var p in people)
      Console.WriteLine(p);

   }


}
