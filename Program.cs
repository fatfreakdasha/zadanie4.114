using System;

Console.WriteLine("введите год");
int year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите номер месяца: ");
int mounth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите день : ");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Дата предыдущего дня: {day - 1}.{mounth}.{year}");
Console.WriteLine($"Дата следующего дня: {day + 1}.{mounth}.{year}");

if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine("год високосный");
}
else
{
    Console.WriteLine("не високосный год");
}