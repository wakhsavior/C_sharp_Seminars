// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int EnterNumber(int min, int max)
{
    int int_num = 0;
    int result = 0;
    bool bol_correct_enter = false;
    string str_num = String.Empty;


    while (bol_correct_enter == false)
    {
        str_num = Console.ReadLine();
        if ((int.TryParse(str_num, out result)) && (result > min && result < max)) bol_correct_enter = true;
        else Console.WriteLine("Incorrect Enter. Try again");
    }
    return result;
}

int SummDigits(int num)
{
    int sum_digits = 0;
    while (num != 0)
    {
        sum_digits = sum_digits + num % 10;
        num/= 10;
    }
    return  sum_digits;

}

Console.WriteLine("Enter number one: 1 - 9999");
int int_number = EnterNumber(0, 10000);

Console.WriteLine($"Summ digits in {int_number} = {SummDigits(int_number)}");
