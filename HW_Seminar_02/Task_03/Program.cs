/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

int i = 0;

while(i <20){

    int number = new Random().Next(1, 10);
    
    if (number <= 7 && number >= 1){
        if (number > 5){
            Console.WriteLine("The {0} day is a weekend",number);
        }
        else {
            Console.WriteLine("The {0} day is not a weekend",number);
        }
    }
    else {
        Console.WriteLine("The {0} is not day of a week", number);
    }

    i++;
}