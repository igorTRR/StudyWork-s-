// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDig(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number%10;
        number = number/10;
    }
    return result;
}
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write($"Сумма цифр числа{A} ={SumDig}(result)");

