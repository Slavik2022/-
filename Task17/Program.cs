﻿// Напишите программу, которая принимает
// 1. на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 
// 3. и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quater = Quarter(x, y);
string result = quater > 0 ? $"Указанные координаты соответствуют четверти -> {quater}" : "Введены некорректные координаты";

Console.WriteLine(result);
