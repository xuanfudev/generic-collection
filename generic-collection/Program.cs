List<int> list = new List<int>();

Console.Write("Nhap do dai list: ");
int lengthList = int.Parse(Console.ReadLine()!);

for (int i = 0; i < lengthList; i++)
{
    var number = Console.ReadLine();
    list.Add(int.Parse(number!));
}

int max = list[0];

foreach (var item in list)
{
    if (item > max)
    {
        max = item;
    }
}

Console.WriteLine("Phan tu lon nhat trong list: " + max);
Console.WriteLine("Phan tu lon nhat trong list: " + list.Max());