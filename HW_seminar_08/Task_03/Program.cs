// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] ProductMatrix(int[,] array1, int[,] array2)
{
    if ((array1.GetLength(0)!=array2.GetLength(0)) || (array1.GetLength(1)!=array2.GetLength(1)))
    {
        Console.WriteLine("Matrixes are not the same size");
        int[,] array = new int[,] {{0},{0}};

        return array;
    }
    
    int[,] resArray = new int[array1.GetLength(0),array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            resArray[i,j] = array1[i,j]*array2[i,j];
        }
    }
    return resArray;
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());  //null - ссылка в пустоту
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array1 = GetArray(rows, columns, 0, 10);
int[,] array2 = GetArray(rows, columns, 0, 10);

PrintArray(array1);

Console.WriteLine();
PrintArray(array2);

Console.WriteLine("Power Matrix 1 of Matrix 2:");


int[,] resArray = ProductMatrix(array1,array2);
PrintArray(resArray);