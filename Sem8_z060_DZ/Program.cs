// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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
void FillArray(int[,,] arr)
{
    int count = 20;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 1;
            }
        }
    }
}

void PrintIndex(int[,,] arrayInd)
{
    for (int i = 0; i < arrayInd.GetLength(0); i++)
    {
        for (int j = 0; j < arrayInd.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arrayInd.GetLength(2); k++)
            {
                Console.Write($"{arrayInd[i, j, k]}({i},{k},{j}) ");
            }
        }
    }
}

Console.Clear();
int[,,] arrayInd = new int[2, 2, 2];
FillArray(arrayInd);
PrintIndex(arrayInd);
Console.WriteLine();
