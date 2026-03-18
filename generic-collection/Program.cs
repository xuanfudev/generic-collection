List<string> list = new List<string>();

Console.Write("Nhap do dai list: ");
int lengthList = int.Parse(Console.ReadLine()!);

for (int i = 0; i < lengthList; i++)
{
    var student = Console.ReadLine();
    list.Add(student!);
}

Console.WriteLine("Danh sach sinh vien: ");
foreach (var student in list)
{
    Console.Write(student + ' ');
}

Console.Write("\n Ban muon xoa ten sinh vien nao: ");
string studentRemove = Console.ReadLine()!;

list.Remove(studentRemove);

Console.WriteLine("Danh sach sinh vien sau khi xoa: ");
foreach (var student in list)
{
    Console.Write(student + ' ');
}