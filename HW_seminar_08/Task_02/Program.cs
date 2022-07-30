// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void PrintIndexRowMinSumm(int[,] array)
{
    int minSummIndex = 0;
    int summ = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summTmp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summTmp += array[i, j];

        }
        if (summ > summTmp)
        {
            summ = summTmp;
            minSummIndex = i;
        }
        Console.WriteLine(summ);
    }
    Console.WriteLine($"Index min Row Summ: {minSummIndex}");


}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());  //null - ссылка в пустоту
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

Console.WriteLine();

PrintIndexRowMinSumm(array);