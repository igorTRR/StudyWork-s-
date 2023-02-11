// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
} 
int SumEl(int[]array)
{
    int i;
    int sum = 0;
    for(i =1; i < array.Length; i+=2)
    {
       sum = sum+array[i];
    }
    return sum;
}   
Console.Clear(); 
int[]array = GetArray(7, 10, 24);
int N = SumEl(array);
Console.WriteLine(string.Join(", ",array));
Console.WriteLine($"Сумма чисел на нечетных позициях масива = {N}");