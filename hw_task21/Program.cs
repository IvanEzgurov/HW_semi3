//Задача 21
//Напишите программу, которая принимает на вход координаты двух т
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите кардинаты по х первой точки");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите кардинаты по y первой точки");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите кардинаты по z первой точки");
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Введите кардинаты по x второй точки");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите кардинаты по y второй точки");
double yb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите кардинаты по z второй точки");
double zb = double.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));

Console.WriteLine(Math.Round(x, 2, MidpointRounding.ToNegativeInfinity));