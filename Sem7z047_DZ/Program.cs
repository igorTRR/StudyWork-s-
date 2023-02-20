﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next();
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i, j]}\t "); 
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}
Console.Write("Введите кол-во строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] inArray = GetArray(m, n, -10, 10);
PrintArray(inArray);
Console.WriteLine();
PrintArray(inArray);