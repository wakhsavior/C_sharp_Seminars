// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Pow(int n, int m)
{
    int pow = n;
    if (m == 0) return 1;
    if (m == 1) // Условие выхода из рекурсии
    {
        Console.WriteLine(pow);
        return pow;
    }
    pow = n * Pow(n, m - 1);   // Обратное приращение рекурсии к выходу
    Thread.Sleep(200);
    Console.WriteLine(pow);

    return pow;

}


Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter Power M: ");
int m = int.Parse(Console.ReadLine());
int mPowN = 1;

mPowN = Pow(n, m);

Console.WriteLine(mPowN);