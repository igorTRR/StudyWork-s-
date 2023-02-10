// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет3; массив [6, 7, 19, 345, 3] -> да

 int[]GetArray(int size, int minVolue, int maxVolue)
 {
    int[] result = new int[size];
     for(int i = 0; i < size; i++)
     {
     result[i] = new Random().Next( minVolue,  maxVolue+1);
     } 
     return result;                       
}
 bool FindeEl(int number, int[]collection)
 {
    foreach (int el in collection)
    {
        if (el == number)
       {
            return true;
         }
    }
     return false;
 }
 int[] Charray = GetArray(12, -9, 9); 
 Console.Write(String.Join(", ",Charray));
 Console.WriteLine("Ведите число: ");
 int n = int.Parse(Console.ReadLine()!);
 if (FindeEl(n, Charray))
    {
    Console.Write($"Заданное число ={n} есть");
    }
  else
    {
    Console.Write($"Заданного числа {n} нет");
}
