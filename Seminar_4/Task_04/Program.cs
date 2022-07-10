// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] GetBinaryArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        // array[i] = new Random().Next(0, 2);
        array[i] = new Random().Next(2);
    }
    return array;
}
int j = 0;
int iterations = 10;
while (j < iterations)
{

    Console.WriteLine($"{String.Join(", ", GetBinaryArray(16))}");
    j++;
}
