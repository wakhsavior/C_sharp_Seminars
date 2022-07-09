// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("The program checks the number for parity");

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
string even = "No";

if (num%2 == 0) {
    even = "Yes";
}

Console.WriteLine("Number {0} is even: {1}",num, even);