// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


int num1 = 7;
int num2 = 23;

while(true){

    int number = new Random().Next(100,1000000);

     Console.WriteLine($"Random number: {number}");

     if(((number % num1) == 0)&&((number % num2)==0)){
        Console.WriteLine($"Number {number} is divided by {num1} and {num2}");
        break;
     }
     else{
        Console.WriteLine($"The remainder of the division {number} to {num1} is {number%num1} and to {num2} is {number%num2}");
     }

}