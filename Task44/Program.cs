// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int num)
{
    int[] arrFibonacci = new int [num];
    arrFibonacci[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arrFibonacci[i] = arrFibonacci[i-1] + arrFibonacci[i-2];
    }
    return arrFibonacci;
}

void PrintArray(int[] array)
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

int[] arrFibonacci = Fibonacci(number);
PrintArray(arrFibonacci);
