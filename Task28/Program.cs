// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Multiply(int number)
{
    int multiply = 1;
    for (int i = 1; i <= number; i++)
    {
        multiply *= i;
    }
    return multiply;
}

int factorial = Multiply(num);
Console.WriteLine($"Произведение чисел 1 до {num} => {factorial}");