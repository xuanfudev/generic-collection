List<int> list = new List<int>();

Console.Write("Nhap do dai list: ");
int lengthList = int.Parse(Console.ReadLine()!);

for (int i = 0; i < lengthList; i++)
{
    var number = Console.ReadLine();
    list.Add(int.Parse(number!));
}

int min = list[0];

foreach (var item in list)
{
    if (item < min)
    {
        min = item;
    }
}

Console.WriteLine("Phan tu nho nhat trong list: " + min);
Console.WriteLine("Phan tu nho nhat trong list: " + list.Min());