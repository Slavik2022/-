﻿// Задача 36: 1. Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
int SumOddPosition(int[] array)
{
   
    int sumOddPosition = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sumOddPosition += array[i];
    }

        return sumOddPosition;
}


int[] arr = CreateArrayRndInt(8, 10, 99);
PrintArray(arr);
int result = SumOddPosition(arr);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {result}");