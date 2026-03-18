List<int> list = new List<int>();

Console.Write("Nhap do dai list: ");
int lengthList = int.Parse(Console.ReadLine()!);

for (int i = 0; i < lengthList; i++)
{
    var number = Console.ReadLine();
    list.Add(int.Parse(number!));
}

int evenCount = 0;

foreach (var item in list)
{
    if (item%2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine("So lương so chan trong list: " + evenCount);