// Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    int thirdDigit = 0;
    while (num > 999)
    {
        num = num / 10;
    }
    if (num > 99) thirdDigit = num % 10;
    return thirdDigit;
}

int thirdDigit = ThirdDigit(Math.Abs(number));
if (thirdDigit > 0) Console.WriteLine($"Третья цифра этого числа: {thirdDigit}");
else Console.WriteLine("Третьей цифры в этом числе НЕТ.");