class Program 
{
   public static void Main()
   {
	Student[] students = new Student[]
	{
    	   new Student("Алексей", "P-101", 4.8),
           new Student("Мария", "P-102", 4.3),
           new Student("Ирина", "P-101", 4.9),
           new Student("Сергей", "P-103", 3.9)
	};

	University university = new University(students);

	Console.WriteLine("\nВсе студенты:");
	university.ShowAll();

	Console.WriteLine("\nЛучшие студенты (GPA > 4.5):");
	foreach (var student in university.GetTopStudents())
    	   Console.WriteLine(student);

	Console.WriteLine("\nСтуденты группы P-101:");
	foreach (var student in university.GetStudentsByGroup("P-101"))
    	   Console.WriteLine(student);
   }
}
