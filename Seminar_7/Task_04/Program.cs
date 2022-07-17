// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

int SummDiagonalElements(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i ==j)
            {
                summ += array[i, j];
                Console.WriteLine($"{array[i,j]} - {summ}");
            }
        }
    }
    return summ;
}

int[,] Fill2DArray(int M, int N)       //Функция заполнения массива натуральными числами от -10 до 10
{
    int[,] array = new int[M, N];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);    //Заполняем массив случайными числами для удобства делаем это Рандомайзером
            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }

    return array;
}

int M = 5;
int N = 5;
int[,] array = new int[M, N];

array = Fill2DArray(M, N);
Console.WriteLine();
Console.WriteLine(SummDiagonalElements(array));