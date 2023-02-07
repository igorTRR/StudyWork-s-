//  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Clear();

int Multi(int numb)
{
    int prod = 1;
    for (int i = 1; i < numb; i++)
    {
        prod *= i;

    }
    return prod;
}
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"Произведение чисел от 1 до {N} = {Multi(N)}");