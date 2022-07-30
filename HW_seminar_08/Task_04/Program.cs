// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

int[,,] Get3DArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] matrix = new int[m, n, k];
    bool duplicate = true;
    int tmp = 0;
    for (int i = 0; i < m; i++)  //Строки. m - matrix.GetLength(0)
    {
        for (int j = 0; j < n; j++)  //Столбцы. n - matrix.GetLength(1)
        {
            for (int z = 0; z < k; z++)
            {
                duplicate = true;
                while (duplicate)
                {
                    duplicate = false;
                    tmp = new Random().Next(minValue, maxValue + 1);
                    foreach (int item in matrix)
                    {
                        if (item == tmp)
                        {
                            duplicate  = true;
                            break;
                        }
                        
                    }
                }
                matrix[i, j, z] = tmp;
            }

        }
    }
    return matrix;
}

void Print3DArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)

    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int z = 0; z < inputArray.GetLength(2); z++)
            {
                Console.Write($"{inputArray[i, j,z]}({i},{j},{z})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());  //null - ссылка в пустоту
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int zDimension = Convert.ToInt32(Console.ReadLine());

int[,,] array = Get3DArray(rows, columns, zDimension, 10, 99);


Print3DArray(array);

Console.WriteLine();

