﻿// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
int lastDigit = number % 10; // 456 % 10 = 45 456 / 10 = 45
Console.WriteLine($"Последняя цифра числа = {lastDigit}");
}
else Console.WriteLine("Введите трёхзначное число!!!");