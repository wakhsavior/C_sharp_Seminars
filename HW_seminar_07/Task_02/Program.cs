// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int m = 5;
int n = 10;

int[,] array = Fill2DArray(m, n);
Print2DArray(array);

Console.WriteLine();

Console.WriteLine("Enter position of the element M x N:");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

int arrayRows = array.GetLength(0);
int arrayColumns = array.GetLength(1);

if ((row > arrayRows) || (column > arrayColumns))
{
    Console.WriteLine("This position does not exist");
}
else
{
    Console.WriteLine(array[row-1, column-1]);
}