Console.WriteLine("Thai Truong Giang_2415053122313");
string[] mangChuoi = new string[]
            {
                "Thai Truong Giang",
                null,
                "",
                "   ",
                "12346",
                null
            };
Console.WriteLine("mang gom: Thai Truong Giang, null, chuoi rong, chuoi khoang trang, 123456, null ");
int dem = 0;

// Duyệt mảng
for (int i = 0; i < mangChuoi.Length; i++)
{
    string s = mangChuoi[i];

    if (!string.IsNullOrEmpty(s))
    {
        dem++;
        Console.WriteLine($"Phan tu hop le la: '{s}'");
    }
}

Console.WriteLine($"So phan tu khac null va khac rong la: {dem}");