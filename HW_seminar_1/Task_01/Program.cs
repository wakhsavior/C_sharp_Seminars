// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Program search min and max numbers");

Console.Write("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2){
    Console.WriteLine("Number {0} is maximum",num1);
} 
else if (num2 > num1){
    Console.WriteLine("Number {0} is maximum",num2);
}

else {
    Console.WriteLine("Number {0} is equal to {1}",num1, num2);
}