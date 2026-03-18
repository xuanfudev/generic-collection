List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Alice" },
    new Student { Id = 2, Name = "Bob" },
    new Student { Id = 3, Name = "Charlie" }
};

foreach (var student in students)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
}

class Student
{
    public int Id;
    public required string Name;
}