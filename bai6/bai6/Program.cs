// See https://aka.ms/new-console-template for more information
Console.WriteLine("Thai Truong Giang_2415053122313");
Console.Write("Nhap so phan tu n: ");
string inputN = Console.ReadLine();


if (string.IsNullOrEmpty(inputN))
{
    Console.WriteLine("mang null");
    return;
}

int n = int.Parse(inputN);
int[] mangSo = new int[n];


for (int i = 0; i < n; i++)
{
    Console.Write($"Phan tu thu {i}: ");
    mangSo[i] = int.Parse(Console.ReadLine());
}


int dem = 0;
for (int i = 0; i < n; i++)
{
    if (mangSo[i] % 2 == 0)
    {
        dem++;
    }
}

Console.WriteLine($"So luong phan tu chan: {dem}");
Console.ReadKey();