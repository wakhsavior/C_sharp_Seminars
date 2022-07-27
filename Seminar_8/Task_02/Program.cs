// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)  //Строки. m - matrix.GetLength(0)
    {
        for (int j = 0; j < n; j++)  //Столбцы. n - matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

/// Печатает массив на экран
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)

    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] TransponArray(int[,] matrix)
{
    int m = matrix.GetLength(1);
    int n = matrix.GetLength(0);

    int[,] transMatrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            transMatrix[i, j] = matrix[j, i];
        }
    }
    return transMatrix;
}


Console.Write("ВВедите количество строк: ");
int rows = int.Parse(Console.ReadLine());  //null - ссылка в пустоту
Console.Write("ВВедите количество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

if (rows == columns)
{
    int[,] transponArray = TransponArray(array);
    Console.WriteLine();
    PrintArray(transponArray);
}
else
{
    Console.WriteLine($"Матрица размером {rows}:{columns} не квадратная");
}
