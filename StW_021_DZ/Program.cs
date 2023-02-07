//Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координаты точек Xa: ");
int Xa = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Ya: ");
int Ya = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Za: ");
int Za = int.Parse(Console.ReadLine()!); 


Console.Write("Введите координаты точек Xb: ");
int Xb = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Yb: ");
int Yb = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Zb: ");
int Zb = int.Parse(Console.ReadLine()!); 


double A = Math.Pow(Xb-Xa,2);
double B = Math.Pow(Yb-Ya,2);
double Z = Math.Pow(Za-Zb,2);

double length= Math.Sqrt( A+B+Z );

Console.Write(Math.Round(length,2));