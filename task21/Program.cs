// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите координату x точки a: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки a: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату z точки a: ");
int az = int.Parse(Console.ReadLine());

Console.Write("Введите координату x точки b: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки b: ");
int by = int.Parse(Console.ReadLine());
Console.Write("Введите координату z точки b: ");
int bz= int.Parse(Console.ReadLine());

double length = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (az - bz) * (az - bz));
Console.WriteLine($"Длинна отрезка {Math.Round(length,2)}");
