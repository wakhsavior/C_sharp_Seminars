// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int [] GetIntArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        // array[i] = new Random().Next(0, 2);
        array[i] = new Random().Next(100);
    }
    return array;
}
int j = 0;
int iterations = 10;
while (j < iterations)
{

    Console.WriteLine($"{String.Join(", ", GetIntArray(8))}");
    j++;
}