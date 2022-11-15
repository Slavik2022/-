// Задача 25: Напишите цикл, который
// 1. принимает на вход два числа (A и B)
// 2. и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите целое число(A): ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число(B): ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {Degree(numberA, numberB)}");
}
else
{
    Console.WriteLine($"Введеное число ненатуральное. Введите число больше 0.");
}
int Degree(int numberA, int numberB)
{
    int result = 1;

    for (int i = 0; i < numberB; i++)
        result *= numberA;

    return result;
}
