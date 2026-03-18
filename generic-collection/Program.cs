Dictionary<string, string> dict = new Dictionary<string, string>();

Console.Write("Nhap so luong tu: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    Console.Write($"Nhap tu tieng Anh {i + 1}: ");
    string eng = Console.ReadLine()!;

    Console.Write($"Nhap nghia tieng Viet {i + 1}: ");
    string vie = Console.ReadLine()!;

    dict[eng] = vie;
}

Console.Write("\nNhap tu tieng Anh can tra: ");
string keyword = Console.ReadLine()!;

if (dict.ContainsKey(keyword))
{
    Console.WriteLine($"Nghia: {dict[keyword]}");
}
else
{
    Console.WriteLine("Khong tim thay!");
}