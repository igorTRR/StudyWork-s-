// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет3; массив [6, 7, 19, 345, 3] -> да

int[]GetArray(int size, int minVolue, int maxVolue)
{
    int[] result = new result(size);
    for(int i = 0; i < size; i++)
    {
    int result = new Random().Next( minVolue,  maxVolue+1);
    } 
    return result;                       
}
int FindeEl( int n, int[] collection);
{
    foreach (int el in collection)
    {
        if (el == n)
        {
            return true;
        }
        
    }
    return false;
}
int[] Charray = GetArray(999, -9, 9); 
Console.Write(String.Join(", ",Charray));
Console.Write("Ведите число: ");
int n = int.Parse(ReadLine()!);

Console.Write($"Заданное число {n} есть, числа {n} нет");



