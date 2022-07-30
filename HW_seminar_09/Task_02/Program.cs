// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Enter number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SummNumbers(int start, int end)
{
    
    if (start == end) return start;

    return start+SummNumbers(start+1, end);
}


Console.WriteLine(SummNumbers(M,N));