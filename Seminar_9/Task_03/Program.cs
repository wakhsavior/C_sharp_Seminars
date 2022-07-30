// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Использовать рекурсию
// 453 -> 12
// 45 -> 9

int SummNumbers(int N)
{
    if (N == 0) return 0;
    return N % 10 + SummNumbers(N / 10);
}

Console.Write("Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());

int summNum = SummNumbers(N);

Console.Write($"Summ {N} = {summNum}");