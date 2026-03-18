List<int> list = new List<int>();

list.AddRange(new[] { 1, 2, 3, 4, 5 });

Console.Write("Danh sach ban dau: ");
foreach (var item in list)
{
    Console.Write(item + " ");
}

list.Reverse();

Console.Write("\nDanh sach sau khi dao nguoc: ");
foreach (var item in list)
{
    Console.Write(item + " ");
}