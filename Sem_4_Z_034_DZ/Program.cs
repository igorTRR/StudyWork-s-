// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
} 
int PozElem(int[]array) 
{
    int count = 0;
    foreach (int el in array)
    {   
        if (el%2 ==0)
        {
            count++;
        }
    }
    return count;
}

int[]array = GetArray(6, 101, 445);
int N = PozElem(array);
Console.WriteLine(string.Join(", ",array));
Console.WriteLine($" четных чисел вмасстве = {N}");