List<string> list = new List<string>();

list.Add("Hello");
list.Add("World");
list.Add("Java");
list.Add("C#");
list.Add("Python");
list.Add("C++");

Console.Write("Danh sach: ");
foreach (var item in list)
{
    Console.Write(item + ' ');
}

list.Sort();

Console.WriteLine("\nDanh sach sau khi sap xep: ");
foreach (var item in list)
{
    Console.Write(item + ' ');
}
