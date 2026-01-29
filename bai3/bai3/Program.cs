Console.Write("Nhap chuoi: ");
string s = Console.ReadLine();
if (s == null)
{
    Console.WriteLine("Chuoi KHONG doi xung");
    return;
}
s = s.Replace(" ", "");

int left = 0;
int right = s.Length - 1;
bool doiXung = true;

while (left < right)
{
    if (s[left] != s[right])
    {
        doiXung = false;
        break;
    }
    left++;
    right--;
}

if (doiXung)
    Console.WriteLine("Chuoi doi xung");
else
    Console.WriteLine("Chuoi KHONG doi xung");