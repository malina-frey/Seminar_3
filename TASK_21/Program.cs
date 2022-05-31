/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки А: ");
Console.WriteLine("Введите координату Х точки А: ");
int pointXA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int pointYA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("Введите координату Х точки B: ");
int pointXB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int pointYB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((pointXA - pointXB) * (pointXA - pointXB) + (pointYA - pointYB) * (pointYA - pointYB));

Console.WriteLine("Расстояние между точками А и В равняется: " + Math.Round(result, 2));