﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Program search min and max numbers");

Console.Write("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > num2){
    if (num1 < num3){
        max = num3;
    }    
} 
else {
    max = num2;
    if (num2 < num3){
        max = num3;
    }
}

Console.WriteLine("Number {0} is maximum",max);