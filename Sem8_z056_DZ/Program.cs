// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindMinSum(int[,] inArray)
{
    int rowMin = 0;
    int rowMinSum = 0;
    int rowSum = 0;
    for (int i = 0; i <inArray.GetLength(1); i++)
    {
        rowMin += inArray[0, i];
    
    }
    for (int i = 0; i <inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) rowSum += inArray[i, j];
        if (rowSum < rowMin )
        {
           rowMin = rowSum;
            rowMinSum = i;
        }
        rowSum = 0;
    }
    Console.Write($"Наименьшая сумма - {rowMin} элементов находится в {rowMinSum+ 1} строке");
}

int[,] inArray = GetArray(3, 4, 2, 7);
PrintArray(inArray);
Console.WriteLine();
FindMinSum(inArray);