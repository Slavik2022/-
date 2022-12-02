// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NaturalsNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        NaturalsNumbers(m+1, n);
    }
    if (m > n)
    {
        Console.Write($"{n} ");
        NaturalsNumbers(n+1, m);
    }
    if(m==n)
    {
        Console.Write($"{m} ");
    }
}

NaturalsNumbers(numberM, numberN);
