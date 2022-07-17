// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] Fill2DDoubleArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double number = new Random().NextDouble();
            number = (Math.Round(number *100))/100;
            array[i, j] = number;
        }
    }
    return array;
}

void Print2DDoubleArray(double[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();

    }
}

Console.WriteLine("Enter matrix dimensions M x N:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = Fill2DDoubleArray(m, n);
Print2DDoubleArray(array);