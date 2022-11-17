// // Задача 38: 1. Задайте массив вещественных чисел.
// // 2. Найдите разницу между максимальным и минимальным элементом массива.

// // [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    // int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} | ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
double DifferenceMaxMinElem(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double result = max - min;
    return result;
}

double[] arr = CreateArrayRndDouble(5, 0, 50);
PrintArray(arr);
double result = DifferenceMaxMinElem(arr);
Console.WriteLine($"Разница между max и min элементами массива = {result}");
