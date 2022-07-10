// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

bool bol_correct_enter = false;
int int_number = 0;
string str_number = String.Empty;
int factorial = 1;
while (bol_correct_enter == false)
{
    Console.WriteLine("Enter number 1 - 15");
    str_number = Console.ReadLine();
    if (((int.TryParse(str_number, out int_number))&&(int_number>1 &&int_number<16)) != true) 
    {
        Console.WriteLine("Incorrect Enter. Try again");
    }
    else bol_correct_enter = true;    
}

for (int i = 2; i <= int_number; i++)
{
    factorial *= i;
    Console.WriteLine($"Factorian {i} = {factorial}");
}

Console.WriteLine($"Factorian {int_number} = {factorial}");