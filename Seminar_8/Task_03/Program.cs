// Задайте двумерный массив из целых чисел. Напишите программу, 
//  которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[] searchMinElem(int[,] matrix)
{
    int minElem = int.MaxValue;
    int[] indexArray = new int[2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElem)
            {
                minElem = matrix[i, j];
                indexArray[0] = i;
                indexArray[1] = j;

            }
        }
    }
    return indexArray;
}

int[,] delRowsColumns(int[,] matrix,int[] minElem)
{
    int[,] changeArray = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int correctI =0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int correctJ = 0;
        if (i==minElem[0])
            {
                correctI=1;
                continue;
            }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j==minElem[1])
            {
                correctJ=1;
                continue;
            }
            else
            {
                changeArray[i-correctI,j-correctJ] = matrix[i,j];
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
        
    }
    return changeArray;
}

Console.Write("ВВедите количество строк: ");
int rows = int.Parse(Console.ReadLine());  //null - ссылка в пустоту
Console.Write("ВВедите количество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

Console.WriteLine();
for (int i = 0; i < searchMinElem(array).Length; i++)
{
    Console.Write(searchMinElem(array)[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("Result Array:");

int[,] correctArray = delRowsColumns(array,searchMinElem(array));

Console.WriteLine();
PrintArray(correctArray);