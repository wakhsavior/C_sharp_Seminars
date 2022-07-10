// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

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



int A_Pow_B(int a, int b)
{
    int pow = a;   
    for (int i =1;i<b;i++)
    {
        pow*=a;
    }
    return pow;
}

Console.WriteLine("Enter number one: 1 - 99");
int int_number_1 = EnterNumber(0,100);

Console.WriteLine("Enter number two: 1 - 99");
int int_number_2 = EnterNumber(0,100);

Console.WriteLine($"{int_number_1} power {int_number_2} = {A_Pow_B(int_number_1,int_number_2)}");
