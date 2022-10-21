// Задача 10: Напишите программу, которая
// 1. принимает на вход трёхзначное число
// 2. и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowSecondDigit(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = Math.Abs(number);
if (number > 99 && number < 1000)
{
    int secondDigit = ShowSecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {secondDigit}.");
}
else Console.WriteLine("Вы ввели не трехзначное число");