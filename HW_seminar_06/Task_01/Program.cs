// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int CountPositiveNumbes(int[] array)   //Функция по поиску количества положительных чисел в массиве, на вход принимает массив, на выход отдает количество чисел
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0)
            count++;
    }
    return count;
}

int[] FillArray(int M)       //Функция заполнения массива натуральными числами от -10 до 10
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = new Random().Next(-10, 11);    //Заполняем массив случайными числами для удобства делаем это Рандомайзером
    }
    return array;
}

Console.WriteLine("Enter the quantity of numbers: ");  //Запрос ввода количества чисел для запуска цикла по формированию массива
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];  //Подготавливаем массив для чисел

array = FillArray(M);
Console.WriteLine($"{String.Join(", ",array)}");

int positiveNumbers = CountPositiveNumbes(array);
Console.WriteLine($"The quantity of positive number: {positiveNumbers}");



