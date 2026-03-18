List<string> list = new List<string>();

list.Add("Hello");
list.Add("World");
list.Add("Java");
list.Add("C#");
list.Add("Python");
list.Add("C++");

Console.Write("Nhap chuoi muon tim kiem: ");
var findString = Console.ReadLine();

bool found = false;

foreach (var item in list)
{
    if (item.Equals(findString))
    {
        Console.WriteLine("Tim thay chuoi: " + item);
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("Khong tim thay chuoi!");
}