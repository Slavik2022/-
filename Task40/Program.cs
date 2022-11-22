// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа через Enter: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

bool IsExthistTriangle(int number1, int number2, int number3)
{
    bool b = number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2;
    return b;
}

bool isExthistTriangle = IsExthistTriangle(number1, number2, number3);
Console.WriteLine(isExthistTriangle);