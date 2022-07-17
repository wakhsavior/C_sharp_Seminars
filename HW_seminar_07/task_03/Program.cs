// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Fill2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int number = new Random().Next(-10, 10);
            array[i, j] = number;
        }
    }
    return array;
}

void Print2DArray(int[,] matrix)
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

int SummInColumn(int[,] array, int j)
{
    int NumberRows = array.GetLength(0);
    int summ = 0;
    for (int i = 0; i < NumberRows; i++)
    {
        summ += array[i, j];
    }
    return summ;
}

int m = 7;
int n = 10;

int[,] array = Fill2DArray(m, n);
Print2DArray(array);

Console.WriteLine();
int NumberColumns = array.GetLength(1);
int NumberRows = array.GetLength(0);

double average = 0;
for (int j = 0; j < NumberColumns; j++)
{
    average = Math.Round((double)SummInColumn(array, j) / NumberRows*100)/100;
    Console.Write(average + "\t");
}


