List<int> grades = new();
Console.WriteLine("Student Information");
for (int i= 0; i <= 5; i++)
{
    while (true)
    {
    Console.Write($"Enter grade{i}: ");
    int grade = int.Parse(Console.ReadLine());
    if (grade > 5 || grade < 1)
    {
        Console.WriteLine("Error! Try again!");
    }
    else
    {
        grades.Add(grade);
        break;
    }
}
}
int MaxGrade = grades.Max();
int minGrade = grades.Min();
double averageGrade = grades.Average();

Console.WriteLine(" Results");
Console.WriteLine($"Maximum grade: {MaxGrade}");
Console.WriteLine($"Minimum grade: {minGrade}");
Console.WriteLine($"Average grade: {averageGrade}");