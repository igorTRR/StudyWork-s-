//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(9);
    }
    return array;
}
void printArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
        Console.Write($"{NewArray[i]} "!); 
}
int[] array = GetArray();
printArray(array);