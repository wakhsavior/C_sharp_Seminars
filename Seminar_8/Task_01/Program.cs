//1. Не повторяйся - делайте методы для одинаковых действий

//2. Не усложняйте, не делайте излишней функциональности

//3. Делай проще

// Задайте двумерный массив.
// Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


/// summary - описание метода
/// m на n: m - количество строк, n - количество столбцов
/// minValue, maxValue
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
            Console.Write(inputArray[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void ChangeRows(int [,] matrix)
{
    int indexLastRows = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int tmp = matrix[0,i];
        matrix[0,i] = matrix[indexLastRows,i];
        matrix[indexLastRows,i] = tmp;
    }
}


Console.Write("ВВедите количество строк: ");
int rows = int.Parse(Console.ReadLine());  //null - ссылка в пустоту
Console.Write("ВВедите количество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows,columns,0,10);

PrintArray(array);
ChangeRows(array);
Console.WriteLine();

PrintArray(array);

