// Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели
// 2. и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

bool DayWeek(int digit)
{
    if(digit==6 || digit==7) return true; 
    return false; 
}

if ( day > 0 && day < 8 ) 
{
    bool result = DayWeek(day);
    Console.WriteLine("День недели выходной?");
    if (result) Console.WriteLine("ДА");
    else Console.WriteLine("НЕТ");
}
else  Console.WriteLine("Введенное число не соотвествует дню недели");
