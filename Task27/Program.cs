// Задача 27: Напишите программу, которая
// 1. принимает на вход число 
// 2. и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int sumDigit)
{
    sumDigit = Math.Abs(number);
    int sum = 0;
    while (sumDigit > 0)
    {
        sum = sum + sumDigit % 10;
        sumDigit = sumDigit / 10;
    }

    return sum;
}

Console.WriteLine($"Сумма всех цифр числа {number} равна {SumDigits(number)}");