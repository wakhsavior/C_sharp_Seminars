// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int count = new Random().Next(0, 10);

Console.Write($"{count}->");
for (int i = 1; i <= count; i++)
{
    Console.Write($"{i*i}, ");
}