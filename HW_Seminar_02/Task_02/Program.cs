/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


// Console.Write("Enter number: ");
// int number = Console.ReadLine();

int i = 0;

while(i <20){

    int number = new Random().Next(10, 1000);

    
    if (number < 100){
        Console.WriteLine("The third digit is absent in {0}", number);
    }
    else {
        int third_digit = number / 100 % 10;
        Console.WriteLine("The third digit in {0} is {1}",number, third_digit);
    }
    i++;
}