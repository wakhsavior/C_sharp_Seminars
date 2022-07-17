// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void Fill2DArray(int M, int N)       //Функция заполнения массива натуральными числами от -10 до 10
{
    int[,] array = new int[M, N];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = i+j;                   //Заполняем массив случайными числами для удобства делаем это Рандомайзером
            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }

}

int M = 4;
int N = 5;

Fill2DArray(M,N);
