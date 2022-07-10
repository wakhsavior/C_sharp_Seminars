// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
bool bol_correct_enter = false;
int int_number = 0;
string str_number = String.Empty;
while (bol_correct_enter == false)
{
    Console.WriteLine("Enter number 1 - 10000");
    str_number = Console.ReadLine();
     if (((int.TryParse(str_number, out int_number))&&(int_number>1 &&int_number<10000)) != true) 
    {
        Console.WriteLine("Incorrect Enter. Try again");
    }
    else bol_correct_enter = true;
    
}

Console.WriteLine($"Length of {str_number}: {str_number.Length}");

int count = 0;

while(int_number!=0)
{
    int_number /= 10;
    count++;
}

Console.WriteLine($"Length of {str_number}: {count}");