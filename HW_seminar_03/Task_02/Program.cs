// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int X1 = new Random().Next(-10, 10);
int Y1 = new Random().Next(-10, 10);
int Z1 = new Random().Next(-10, 10);

int X2 = new Random().Next(-10, 10);
int Y2 = new Random().Next(-10, 10);
int Z2 = new Random().Next(-10, 10);

double distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));

Console.WriteLine($"Point 1- {X1}:{Y1}:{Z1}");
Console.WriteLine($"Point 2- {X2}:{Y2}:{Z2}");
Console.WriteLine($"Distance between 1 and 2: {Math.Round(distance * 100) / 100}");