using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
int count=0;
Console.WriteLine("Введите текст");
string s= Console.ReadLine();
string res = @"Input.txt";
StreamReader sr = new StreamReader(res);
string r = sr.ReadLine();
bool result = Regex.IsMatch(s, r);
Console.WriteLine($"Поиск слова {r}");
if (result == true)
{
    count++;
}
if (count == 0)
Console.WriteLine("Совпадений нет");
else
    Console.WriteLine($"Совпадений:{count}");