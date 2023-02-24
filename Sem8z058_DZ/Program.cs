// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] CompositionMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixFird = new int[matrixFirst.GetLength(0),matrixSecond.GetLength(1)];
    if(matrixFirst.GetLength(1) != matrixSecond.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        return matrixFird;
    }
    for (int i = 0; i < matrixFird.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFird.GetLength(1); j++)
        { 
            for (int k = 0; k< matrixFirst.GetLength(0); k++)
            {
                matrixFird[i,j] += matrixFirst[i, k] * matrixSecond[j,k];
            }
        }    
    }
    return matrixFird;
}
Console.Clear();
Console.Write("Введите размерность matrixFirst массива : ");
int[] demensionFirst = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);
int[,] matrixFirst = GetArray(demensionFirst[0], demensionFirst[1], -5, 5 );

Console.Write("Введите размерность matrixSecond массива : ");
int[] demensionSecond =Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);;
int[,] matrixSecond = GetArray(demensionSecond[0] ,demensionSecond[1], -5, 5 );

PrintMatrix(matrixFirst);
Console.WriteLine();
PrintMatrix(matrixSecond);

int[,] matrixFird = CompositionMatrix(matrixFirst, matrixSecond);  
Console.WriteLine();
PrintMatrix(matrixFird);

