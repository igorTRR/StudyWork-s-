//Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NaturalSum (int m, int n,int sum )
{
    if  (m > n )
    {
        Console.WriteLine ( $" Сумма натуральных элементов в промежутке от M до N: = { sum } " );
        return;
    }
     sum = sum + ( m ++ );
    NaturalSum ( m, n, sum);

}
Console.Clear();
Console.Write(" Введите начальное число m: " );
int m = int.Parse(Console.ReadLine()!);
Console.Write(" Введите начальное число n: " );
int n = int.Parse(Console.ReadLine()!);
NaturalSum (m ,n , 0);