Console.Write("Nhap chuoi: ");
String chuoi = Console.ReadLine();

if (chuoi == null)
{
    Console.WriteLine("So tu: 0");
    return;
}
chuoi = chuoi.Trim();

if (chuoi.Length == 0)
{
    Console.WriteLine("So tu: 0");
    return;
}

string[] words = chuoi.Split(
    new char[] { ' ' },
    StringSplitOptions.RemoveEmptyEntries
);

Console.WriteLine("So tu: " + words.Length);
Console.ReadKey();