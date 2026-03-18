Dictionary<char, int> dict = new Dictionary<char, int>();

Console.Write("Nhap chuoi: ");
string input = Console.ReadLine()!;

foreach (char c in input)
{
    if (dict.ContainsKey(c))
    {
        dict[c]++;
    }
    else
    {
        dict[c] = 1;
    }
}

Console.WriteLine("Ket qua:");
foreach (var item in dict)
{
    Console.Write(item.Key + " : " + item.Value + " ");
}