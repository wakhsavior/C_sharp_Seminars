// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] GetIntArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        // array[i] = new Random().Next(0, 2);
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

int[] array = GetIntArray(20,100,999);
int even_numbers_count = 0;

foreach (int number in array)
{

    if (number%2==0)
    {
        even_numbers_count++;
    }
}
Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($"The amount of even numbers in the array: {even_numbers_count}");