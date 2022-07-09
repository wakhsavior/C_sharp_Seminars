// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) Console.WriteLine("1");
if (X > 0 && Y < 0) Console.WriteLine("4");
if (X < 0 && Y < 0) Console.WriteLine("3");
if (X < 0 && Y > 0) Console.WriteLine("2");
