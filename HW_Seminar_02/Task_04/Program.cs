/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

// Console.Write("Enter number: ");
// int number = Console.ReadLine();
int i = 0;

while (i < 10)
{

    int number = new Random().Next(100, 100000);

    string str_number = Convert.ToString(number);



    Console.WriteLine("The second digit in {0} is {1}", number, str_number[str_number.Length - 2]);
    i++;
}