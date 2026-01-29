// See https://aka.ms/new-console-template for more information
Console.WriteLine("Thai Truong Giang_2415053122313");
Console.WriteLine("nhap so phan tu mang: ");
int n = int.Parse(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("n phai lon hon 0");
    return;
}
int[] mangSo = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Phan tu thu {i}: ");
    mangSo[i] = int.Parse(Console.ReadLine());
}

int tong = 0;
for (int i = 0; i < n; i++)
{
    tong += mangSo[i];
}

Console.WriteLine($"Tong la: {tong}");
Console.ReadKey();
