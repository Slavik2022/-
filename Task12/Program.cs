// Напишите программу, которая 
// 1. будет принимать на вход два числа и
// 2. выводить, является ли 1 число
// кратным 2. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num1 % num2;
// if (result > 0)
// {
//     Console.WriteLine($"Некратное. Остаток от деления: {result}");
// }
// else
// {
//     Console.WriteLine($"Числа кратны.");
// }




if (num1 % num2 == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Некратно, остаток {num1 % num2}");
