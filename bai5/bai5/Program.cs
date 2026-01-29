Console.WriteLine("Thai Truong Giang_2415053122313");
Console.Write("Nhap so phan tu n: ");
int n = int.Parse(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Mang rong");
    return;
}
int[] mangSo = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Phan tu thu {i}: ");
    mangSo[i] = int.Parse(Console.ReadLine());
}
int max = mangSo[0];
for (int i = 1; i < n; i++)
{
    if (mangSo[i] > max)
    {
        max = mangSo[i];
    }
}

Console.WriteLine($"Gia tri max la: {max}");
Console.ReadKey();