// Задача 10: Напишите программу, которая
// 1. принимает на вход трёхзначное число
// 2. и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число от 99 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit(int num)
{
    int firstDigit = num / 10;
    int num_2_ = firstDigit % 10;
    Console.WriteLine(num);
    return num_2_;
}
int res = secondDigit(number);
Console.WriteLine(res);