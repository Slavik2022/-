// Напишите программу, которая
// принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Polindrome (int num)
{
    int firstDigit = num / 10000;
    int secodDigit = num / 1000 % 10;
    int fourDigit = num / 10 % 10;
    int fiveDigit = num % 10;
    if (firstDigit==fiveDigit && secodDigit==fourDigit)return true;
    return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool result = Polindrome(number);
    Console.Write($"{number} - это число является палиндромом?");
    if (result) Console.Write(" Является полиндромом.");
    else Console.Write(" Не является полиндромом.");
}
else Console.Write("Вы ввели не пятизначное число!!");