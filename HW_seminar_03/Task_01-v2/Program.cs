// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Revertstr(string str)
{
    int length = str.Length;
    string str_new = String.Empty;
    for(int i=0;i<length; i++)
    {
        str_new = str_new + str[length-i-1];
    }
    return str_new;

}

while (true)
{
    int int_number = new Random().Next(10000, 100000);
    // int int_number = Convert.ToInt32(Console.ReadLine());

    string str_number = Convert.ToString(int_number);
    
    string str_revert = Revertstr(str_number);

    // Console.WriteLine($"{str_number}");
    // Console.WriteLine($"{str_revert}");
    // Console.WriteLine();
    
    if(str_number == str_revert) 
    {
        Console.WriteLine($"The number {int_number} is polindrome");
        break;
    }
    else Console.WriteLine($"The number {int_number} is not polindrome");
    
}

