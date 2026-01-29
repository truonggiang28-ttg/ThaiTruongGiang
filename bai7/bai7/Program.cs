// See https://aka.ms/new-console-template for more information
Console.WriteLine("Thai Truong Giang_2415053122313");
Console.Write("Nhap ho ten: ");
string hoTen = Console.ReadLine();
if (hoTen == null)
{
    Console.WriteLine("loi null");
    return;
}

string[] cacTu = hoTen.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

if (cacTu == null || cacTu.Length == 0)
{
    Console.WriteLine("Khong co tu nao de in");
    return;
}

Console.WriteLine("Cac tu trong ten la");
for (int i = 0; i < cacTu.Length; i++)
{
    Console.WriteLine(cacTu[i]);
}