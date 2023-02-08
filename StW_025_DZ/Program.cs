// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Multi(int A, int B)
{
    int i = 1;
    int res = i;
    for(i = 1; i <= B; i ++) 
    {
        res =res*A;
    }   
       return res;
}
Console.Clear();
Console.Write("Введите число A: ");
int A =int.Parse(Console.ReadLine()!);
Console.Write("Введите степень возведения B: ");
int B =int.Parse(Console.ReadLine()!);

Console.Write($"Число {A} в степени {B} равно {Multi(A, B)}");