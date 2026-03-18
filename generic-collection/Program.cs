List<int> list = new List<int>();

Console.Write("Nhap so luong phan tu: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    Console.Write($"Phan tu thu {i + 1}: ");
    list.Add(int.Parse(Console.ReadLine()!));
}

Dictionary<int, int> dict = new Dictionary<int, int>();

foreach (int num in list)
{
    if (dict.ContainsKey(num))
        dict[num]++;
    else
        dict[num] = 1;
}

int maxCount = 0;
int result = list[0];

foreach (var item in dict)
{
    if (item.Value > maxCount)
    {
        maxCount = item.Value;
        result = item.Key;
    }
}

Console.WriteLine($"Phan tu xuat hien nhieu nhat: {result} ({maxCount} lan)");