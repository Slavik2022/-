// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// double Factorial(int n)
// {
// if (n == 1) return 1; // это условие определение факториала 1!=1 (0!=1)
// else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}");
// }


Console.WriteLine("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int CubeNumber(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * CubeNumber(numA, numB - 1);
}

while (numberB < 0)
{
    Console.WriteLine($"Введено отрицательное число.");
    Console.Write("Введите натуральное число B: ");
    numberB = Convert.ToInt32(Console.ReadLine());
}

int cubeNum = CubeNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно -> {cubeNum}");