//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.Write("Введите день недели: ");
int n = int.Parse(Console.ReadLine()!);

 if(n== 6 || n==7)
{
    Console.Write(" ДА -> выходной день");

else 
    {
    if(n<=5)
    

    Console.Write("Нет");
    }
}    
