// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
} 
int[] array =GetArray(10, 12,32);
Console.WriteLine(String.Join(", ",array));
int max =0;
int min =0;
foreach (int el in array)
{
    max+=el>0? el:0;
    min+=el<=0? el:0;
}