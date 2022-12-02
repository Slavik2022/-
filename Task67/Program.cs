// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// double Factorial(int n)
// {
// if (n == 1) return 1; // это условие определение факториала 1!=1 (0!=1)
// else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}");
// }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElementNumber(int num)
{
    if (num == 0) return num; // это условие определение факториала 1!=1 (0!=1)
    return num % 10 + SumElementNumber(num / 10);
}

int sumElemNum = SumElementNumber(number);
Console.WriteLine($"Сумма его цифр -> {sumElemNum}");
