// Задача 62. Заполните спирально массив 4 на 4.


int[,] GetSpiralArray(int m, int minValue, int maxValue)
{
    int[,] matrix = new int[m, m];
    for (int z = 0; z < (m / 2 + m % 2); z++)
    {
        int i = z;
        int j = z;
        while (j < m - z)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
            j++;
            Console.Clear();
            PrintArray(matrix);
            Thread.Sleep(200);
        }
        j--;
        i++;
        while (i < m - z)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Clear();
            PrintArray(matrix);
            Thread.Sleep(200);
            i++;
        }
        i--;
        j--;
        while (j >= z)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Clear();
            PrintArray(matrix);
            Thread.Sleep(200);
            j--;
        }
        j++;
        i--;
        while (i > z)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Clear();
            PrintArray(matrix);
            Thread.Sleep(200);
            i--;
        }
        i++;

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

Console.Write("Введите размер квадратной матрицы: ");
int m = int.Parse(Console.ReadLine());  //null - ссылка в пустоту

int[,] array = GetSpiralArray(m, 1, 30);

PrintArray(array);

Console.WriteLine();
