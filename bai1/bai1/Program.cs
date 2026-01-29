Console.Write("Nhap ho ten: ");
String ht = Console.ReadLine();
String hotenxoa = ht.Trim();
if (String.IsNullOrWhiteSpace(ht))
{
    Console.WriteLine("Loi, chuoi rong");
    return;
}
Console.WriteLine("da xoa ki tu trang dau cuoi: " + hotenxoa);
string[] danhSachTu = ht.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

string ketQua = "";

for (int i = 0; i < danhSachTu.Length; i++)
{
    string tu = danhSachTu[i];

    string tuDaXuLy = char.ToUpper(tu[0]) + tu.Substring(1).ToLower();

    ketQua += tuDaXuLy;

    if (i < danhSachTu.Length - 1)
    {
        ketQua += " ";
    }
}

Console.WriteLine("ket qua: " + ketQua);
Console.ReadKey();
