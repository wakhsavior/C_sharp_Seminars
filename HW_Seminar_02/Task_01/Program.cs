/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

// Console.Write("Enter number: ");
// int number = Console.ReadLine();
int i = 0;

while(i <10){

    int number = new Random().Next(100, 1000);

    int second_digit = number / 10 % 10;

    Console.WriteLine("The second digit in {0} is {1}",number, second_digit);
    i++;
}