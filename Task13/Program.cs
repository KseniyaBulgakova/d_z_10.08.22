Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(number);
if (s.Length > 2)
{
Console.WriteLine("Третья цифра числа:" + s[2]);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет!");
}