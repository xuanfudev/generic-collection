List<Student> students = new List<Student>();

Console.Write("Nhap so luong sinh vien: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    Student sv = new Student();

    Console.Write($"Nhap ten sinh vien {i + 1}: ");
    sv.Name = Console.ReadLine()!;

    Console.Write($"Nhap diem sinh vien {i + 1}: ");
    sv.Score = double.Parse(Console.ReadLine()!);

    students.Add(sv);
}

double maxScore = students[0].Score;

foreach (var sv in students)
{
    if (sv.Score > maxScore)
    {
        maxScore = sv.Score;
    }
}

Console.WriteLine("\nSinh vien co diem cao nhat:");
foreach (var sv in students)
{
    if (sv.Score == maxScore)
    {
        Console.WriteLine($"Name: {sv.Name}, Score: {sv.Score}");
    }
}

class Student
{
    public string Name { get; set; }
    public double Score { get; set; }
}