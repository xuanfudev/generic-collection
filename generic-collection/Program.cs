List<Student> students = new List<Student>();

Console.Write("Nhap so luong sinh vien: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    Student sv = new Student();

    Console.Write($"Nhap Id sinh vien {i + 1}: ");
    sv.Id = int.Parse(Console.ReadLine()!);

    Console.Write($"Nhap ten sinh vien {i + 1}: ");
    sv.Name = Console.ReadLine()!;

    students.Add(sv);
}

Console.WriteLine($"\nTong so sinh vien: {students.Count}");

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}