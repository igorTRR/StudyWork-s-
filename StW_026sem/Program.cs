// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//  456 -> 3 78 -> 2 89126 -> 5


int DigitCount(int A)
{
    int counnt = 0;
    while(A!= 0)
    {
        A/=10;
        counnt ++;
    } 
    return counnt;
}
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(DigitCount(N));