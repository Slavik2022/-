// Напишите программу, которая 
// 1. выводит случайное трёхзначное число
// 2. и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число от 100 до 999: {number}");
// int firstDigit = number / 100;
// Console.WriteLine($"1 цифра: {firstDigit}");
// //int secondDigit = number / 10;

// int fithDigit = number % 10;
// Console.WriteLine($"3 цифра: {fithDigit}");

// int result = firstDigit * 10 + fithDigit;
// Console.WriteLine($"вывод: {result}");

int RmSecondNum (int number)
{
    int FirstDig = number / 100;
    int ThirdhDig = number % 10;
    int num1_3 = FirstDig * 10 + ThirdhDig;
    Console.WriteLine(number);
    return num1_3;
}

int res = RmSecondNum(new Random().Next(100, 1000));
Console.WriteLine(res);

