List<Student> students = new List<Student>([
    new Student { Id = 1, Name = "Alice" },
    new Student { Id = 2, Name = "Bob" },
    new Student { Id = 3, Name = "Charlie" }
]);

Console.Write("Danh sach sinh vien:\n");
foreach (var sv in students)
{
    Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}");
}

Console.Write("\nNhap ID can xoa: ");
int id = int.Parse(Console.ReadLine()!);

bool removed = false;

for (int i = 0; i < students.Count; i++)
{
    if (students[i].Id == id)
    {
        students.RemoveAt(i);
        removed = true;
        break;
    }
}

if (removed)
{
    Console.WriteLine("Da xoa sinh vien!");
}
else
{
    Console.WriteLine("Khong tim thay sinh vien!");
}

// In lại danh sách
Console.WriteLine("\nDanh sach sinh vien con lai:");
foreach (var sv in students)
{
    Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}");
}


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}