using System;

public static class ArrayUtils
{
   public static int GetMaxValue(Person[] people)
   {
        if (people == null || people.Length == 0)
            throw new ArgumentException("Массив пуст или равен null.");

        int maxAge = people[0].Age;

        foreach (var person in people)
        {
            if (person.Age > maxAge)
                maxAge = person.Age;
        }

        return maxAge;
    }

    public static void SortByAge(Person[] people)
    {
        Array.Sort(people, (p1, p2) => p1.Age.CompareTo(p2.Age));
    }

    public static Person[] FilterAdults(Person[] people)
    {
        return people.Where(p => p.Age >= 18).ToArray();
    }

    public static double GetAverageAge(Person[] people)
    {
        if (people == null || people.Length == 0)
            return 0;

        return people.Average(p => p.Age);
    }

    public static Person[] GenerateSampleData()
    {
        return new Person[]
        {
            new Person("Анна", 19),
            new Person("Иван", 25),
            new Person("Ольга", 17),
            new Person("Дмитрий", 31)
        };
    }
}
