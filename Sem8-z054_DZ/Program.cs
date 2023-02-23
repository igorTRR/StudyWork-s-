﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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
}
void RegulateMax(int[,] inArray2D)
{
    for (int i = 0; i < inArray2D.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2D.GetLength(1); j++)
        {
            for (int k = 0; k < inArray2D.GetLength(1) - 1; k++)
            {
                if (inArray2D[i, k] < inArray2D[i, k + 1])
                {
                    int temp = inArray2D[i, k + 1];
                    inArray2D[i, k + 1] =inArray2D[i, k];
                    inArray2D[i, k] = temp;
                }
            }
        }
    }
}

int[,] inArray2D= GetArray(4, 4, 1, 9);
PrintArray(inArray2D);
Console.WriteLine();
RegulateMax(inArray2D);
PrintArray(inArray2D);
