// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] GetDoubleArray(int size, double min, double max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        // array[i] = new Random().Next(0, 2);
        array[i] = new Random().NextDouble();
    }
    return array;
}

double[] array = GetDoubleArray(20,-1000,1000);

double min = array.Min();
double max = array.Max();

double diff_min_max = max - min;


Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($"Difference between min and max: {diff_min_max}");