// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <=A; i++)
    {
        sum +=1; // sum = sum + 1
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write($"Сумма чисел от до {A} равна {GetSum()}");