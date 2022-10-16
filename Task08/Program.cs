// Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    int count = 2;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count += 2;
        // count = count + 2;
    }
}
else Console.WriteLine("Введите целое положительное число, которое больше 1 !!!");