// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] PointLineIntersection(double k1, double b1, double k2, double b2) // Функция вычисляет координаты точки пересечения прямых линий заданных уравнениями 
                                                //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 передаются в качестве аргументов
                                                // Для вычисления координат приравняем функции друг к другу и найдем x, затем вычислим y
{
    Console.WriteLine($"k1 - {k1}, k2 - {k2}, b1 - {b1}, b2 - {b2}"); 
    double[] coordinates = new double[2];
    coordinates[0] = (b2 - b1) / (k1 - k2);
    Console.WriteLine(coordinates[0]);
    coordinates[1] = k1 * coordinates[0] + b1;
    Console.WriteLine(coordinates[1]);
    return coordinates;
}

double k1 = 0;
double k2 = 0;
double b1 = 0;
double b2 = 0;

Console.WriteLine("Вычисление координат точки пересечения прямых заданных формулами y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите k1:");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1:");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
b2 = Convert.ToDouble(Console.ReadLine());

double[] coordinates = PointLineIntersection(k1,b1,k2, b2);

Console.WriteLine($"Intersection point coordinates X: {coordinates[0]}, Y: {coordinates[1]}");
