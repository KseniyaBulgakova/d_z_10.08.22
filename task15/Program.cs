﻿Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
    Console.WriteLine("Рабочий день!");
    break;
    case 2:
     Console.WriteLine("Рабочий день!");
    break;
    case 3:
     Console.WriteLine("Рабочий день!");
    break;
    case 4:
     Console.WriteLine("Рабочий день!");
    break;
    case 5:
     Console.WriteLine("Короткий рабочий день!");
    break;
    case 6:
     Console.WriteLine("Выходной день!");
    break;
    case 7:
     Console.WriteLine("Выходной день!");
    break;
    default:
    Console.WriteLine("нет такого числа!");
    break;
}
