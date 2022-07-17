// *Задача 49: *Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void ChangeOddIndexes(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0&&j%2==0)
            {  
                array[i,j] *= array[i,j];
            }    //Заполняем массив случайными числами для удобства делаем это Рандомайзером
                 Console.Write(array[i,j]+ "\t");
        }
     Console.WriteLine();
    }

}


int[,] Fill2DArray(int M, int N)       //Функция заполнения массива натуральными числами от -10 до 10
{
    int[,] array = new int[M,N];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10, 11);    //Заполняем массив случайными числами для удобства делаем это Рандомайзером
            Console.Write(array[i,j]+ "\t");

        }
        Console.WriteLine();
    }

    return array;
}

int M=5;
int N=5;
int[,] array = new int[M,N];

array = Fill2DArray(M,N);
Console.WriteLine();

ChangeOddIndexes(array);
