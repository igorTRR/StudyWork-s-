// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,]GetArray(int m,int n)
{
 int[,] inArary = new int[m, n];
 return inArary;
}
void SpiralArray(int[,] inArray)
{
   int m = inArray.GetLength(0); 
   int n = inArray.GetLength(1);
   int k =1;

   bool[,] spiral =new bool[m,n];
   bool isEnd = false;
   int i =0;
   int j = 0;

   while (!isEnd)
   {
        isEnd = true;
   
        while (j < n-1 && !spiral[i, j+1])
        {
             isEnd = false;
            inArray[i, j] = k++;
            spiral[i, j] = true;
            ++j;
        }    
        while (i < m -1 && !spiral[i+1, j])
        {
            isEnd = false;
            inArray[i, j] = k++;
            spiral[i, j] = true;
            ++i;
        }
        while (j > 0  && !spiral[i, j-1])
        {
            isEnd = false;
            inArray[i, j] = k++;
            spiral[i, j] = true;
            --j;
        }
        while (i > 0  && !spiral[i-1, j])
        {
            isEnd = false;
            inArray[i, j] = k++;
            spiral[i, j] = true;
            --i;
        }
        inArray[i, j] =k;  
   } 

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
Console.Clear();
Console.Write("row: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("colum: ");
int colum = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(row,colum );
SpiralArray(Array);
PrintArray(Array);