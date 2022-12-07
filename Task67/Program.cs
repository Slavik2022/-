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


// int InputNumber(string message)
// {
// while (true)
// {
// Console.Write(message);
// bool result = int.TryParse(Console.ReadLine(), out int value);

// if (!result)
// {
// Console.WriteLine($"Введены некоректные данные. {message} еще раз!");
// Thread.Sleep(1500);
// Console.Clear();

// continue;
// }

// if (value < 0)
// {
// Console.WriteLine($"Число не может быть отрицательным. {message} еще раз!");
// Thread.Sleep(1500);
// Console.Clear();

// continue;
// }
// return value;
// }
// }