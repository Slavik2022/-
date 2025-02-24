﻿// Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// 2. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    // int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    return new int[]{sumPositive,sumNegative};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов равна {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов равна {getSumPositiveNegativeElem[1]}");