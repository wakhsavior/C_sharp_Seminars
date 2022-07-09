// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("The program outputs all even numbers from 1 to N");

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= num; i++){
    if (i%2 ==0){
        Console.WriteLine("The {0} is even.",i);
    }
}