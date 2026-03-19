using System;


public class University
{
    private Student[] students;

    public University(Student[] students)
    {
        this.students = students;
    }

    public List<Student> GetTopStudents()
    {
        List<Student> result = new List<Student>();

        foreach (var student in students)
        {
            if (student.GPA > 4.5)
                result.Add(student);
        }

        return result;
    }

    public List<Student> GetStudentsByGroup(string group)
    {
        List<Student> result = new List<Student>();

        foreach (var student in students)
        {
            if (student.Group == group)
                result.Add(student);
        }

        return result;
    }

    public void ShowAll()
    {
        foreach (var student in students)
            Console.WriteLine(student);
    }
}
