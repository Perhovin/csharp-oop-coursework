using System.Numerics;
using System.Runtime.CompilerServices;

class Course
{
    public string Name;
    public static int TotalCourses = 0;
    public Course(string name)
    {
        Name = name;
        TotalCourses++;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Amount of Courses: {TotalCourses}");
    }
}
class Program
{
    static void Main()
    {
        Course Course1 = new Course("Misha");
        Course Course2 = new Course("Fedr");
        Course1.PrintInfo();
        Course2.PrintInfo();
    }
}