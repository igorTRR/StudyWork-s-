// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

Console.Clear();

int[] getArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void printArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)

        Console.Write($"{inArray[i]} ");
}

int[] array = getArray();
printArray(array);