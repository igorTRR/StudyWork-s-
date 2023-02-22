// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();

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
string ResivElements(int m, int n, int[,] inArray)
{
    if( m < 0 || n < 0 ) return "m,n положительные";
   string result ;
    bool Elements = m <= inArray.GetLength(0)-1 && n <= inArray.GetLength(1)-1;
    if (Elements)
    {
          result =$"{m},{n}-> {inArray[m,n]}";
    }

     else
    {
     result =$"{m},{n}-> Такой позиции нет";
    }
    return result;
}
Console.Clear();

int row = new Random().Next(3,5);
int colums = new Random().Next(3,5);

int[,]inArray = GetArray(row, colums, -5, 5);
PrintArray(inArray);
Console.WriteLine();
Console.WriteLine("Введите позицию элемента в двухмезном массиве ");
int[] position = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);
int m = position(0), n=position(1);
Console.WriteLine(ResivElements(m, n, inArray));
