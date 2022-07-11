// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int N = 8;

int firstElement = 0;
int secondElement = 1;

Console.WriteLine(firstElement);
Console.WriteLine(secondElement);


// for (int i = 2; i < N; i++)
// {
//     int nextElement = firstElement+secondElement;
//     firstElement = secondElement;
//     secondElement=nextElement;
//     Console.WriteLine(nextElement);
    
// }

for (int i = 2; i < N; i++)
{
    secondElement += firstElement;
    firstElement = secondElement-firstElement;
    Console.WriteLine(secondElement);
    
}