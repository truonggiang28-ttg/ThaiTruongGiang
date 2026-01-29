using System.Text;
Console.WriteLine("Thai Truong Giang_2415053122313");
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhap chuoi: ");
string cau = Console.ReadLine();

if (string.IsNullOrEmpty(cau))
    return;

string[] words = cau.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

if (words.Length == 0)
    return;

string maxWord = words[0];
foreach (var w in words)
{
    if (w.Length > maxWord.Length) maxWord = w;
}

Console.WriteLine($"Tu dai nhat: {maxWord}");