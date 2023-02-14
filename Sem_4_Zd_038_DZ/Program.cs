// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double [size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()* (maxValue -minValue) + maxValue;
    }
    return result;
}
double[]MaxV(double[]array)
{
    double max = array[0];  
    for (int i = 0; i < array.Length; i++)
    {
       if ((array[i] < 0)) 
        {
            max = array[i]; 
        }  
    }
    return  max;
}
double MinV(double[]array)
{
    double min = array[0];  
    for (int i = 0; i < array.Length; i++)
    {
       if ((array[i] < 0)) 
        {
            min = array[i]; 
        }  
    }
    return min;
} 
  
double[] array = GetArray(10, 12, 32);
Console.WriteLine(String.Join(", ", array));
double MaxMin = MaxV(array)-MinV(array);
Console.WriteLine($"MaxMin");