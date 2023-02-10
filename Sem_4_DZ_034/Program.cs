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
int EvElement(int[]array) 
{
    
    int sum = 0;
    int positiveSum = 0;
    foreach (int el in array)
    {
    sum+=el%2==0? el:0;
    positiveSum += el> 0 ? el : 0;
    }
    return sum;
   

}




int[]array = GetArray(4, 101, 445);
int N = EvElement(array);
Console.WriteLine(string.Join(", ",array));
Console.WriteLine($"Сумма четных чисел = {N}");