﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int  m, int  n)
{
  if (m == 0)
  {
    return  n + 1;
  }
  else if  ( n == 0 )
   { 
     return Akkerman ( m - 1, 1);  
   }
    else return Akkerman( m - 1 ,  Akkerman( m ,  n - 1 ));
}
Console.Clear();
Console.Write($"Введите число m: "!);
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите число n: "!);
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine( Akkerman( m , n ));
