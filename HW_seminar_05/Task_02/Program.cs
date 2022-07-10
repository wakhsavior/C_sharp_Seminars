// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int[] array = GetIntArray(20,-999,999);
int sum_odd_elements = 0;

for(int i=0;i<array.Length;i=i+2)
{
    sum_odd_elements += array[i];
}

Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($"The sum of odd elements in the array: {sum_odd_elements}");