// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double RezX(double b1, double k1, double b2, double k2)
{
    
    double x =(b2-b1)/(k1-k2);
    return  x;
}
double RezY(double b1, double k1, double x )
    {
    double y = ( k1*x ) +b1;
    return y;
    }
   

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double x = RezX( b1, k1,  b2, k2);
double y = RezY(b1, k1, x);

Console.WriteLine($"{ x }, { y }" );

