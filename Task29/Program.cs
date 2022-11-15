// Задача 29: Напишите программу, которая
// 1. задаёт массив из 8 элементов 
// 2. и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите количество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] NameArray(int size)
{
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
}
int [] nameArray = NameArray(num);
PrintArray(nameArray);