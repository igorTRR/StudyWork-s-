// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

void sigChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
SigChange(array);
Console.WriteLine(String.Join(", ", array));