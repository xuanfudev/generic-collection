List<int> list = new List<int>();

Console.Write("Nhap do dai list: ");
int lengthList = int.Parse(Console.ReadLine()!);

for (int i = 0; i < lengthList; i++)
{
    var number = Console.ReadLine();
    list.Add(int.Parse(number!));
}

int sum = 0;

foreach (var item in list)
{
    sum += item;
}

Console.WriteLine("Tong phan tu trong list: " + sum);