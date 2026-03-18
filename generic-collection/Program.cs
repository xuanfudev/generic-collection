List<int> list = new List<int>();
List<int> newList = new List<int>();

Console.Write("Nhap so luong phan tu: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    Console.Write($"Phan tu thu {i + 1}: ");
    list.Add(int.Parse(Console.ReadLine()!));
}

foreach (var item in list)
{
    if (!newList.Contains(item))
    {
        newList.Add(item);
    }
}

Console.Write("Danh sach khong trung: ");
foreach (var item in newList)
{
    Console.Write(item + " ");
}