// Задача 58: Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }

}


int[,] MultyplyMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(1), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            result[i, j] = MultElem(i, j, array1, array2);
        }
    }
    return result;
}

int MultElem(int elemI, int elemJ, int[,] array1, int[,] array2)
{
    int result = 0;

    for (int i = 0; i < array1.GetLength(1); i++)
    {
        result += array1[elemI, i] * array2[i, elemJ];
    }
    return result;
}

bool MultyplyAbility(int[,] array1, int[,] array2) => array1.GetLength(1) == array2.GetLength(0);

int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 5);   
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 5);   
PrintMatrix(matrix2);
Console.WriteLine();

if (MultyplyAbility(matrix1, matrix2))
{
    Console.WriteLine("Произведение:");
    int[,] matrix3 = MultyplyMatrix(matrix1, matrix2);
    PrintMatrix(matrix3);
}
else
{
    Console.WriteLine("Матрицы нельзя перемножить!");
}