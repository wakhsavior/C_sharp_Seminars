// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

while (true)
{
    int int_number = new Random().Next(10000, 100000);
    // int int_number = Convert.ToInt32(Console.ReadLine());

    string str_number = Convert.ToString(int_number);
    int length = str_number.Length;
    int count = 0;

    for (int i = 0; i < (length / 2); i++)
    {
        if(str_number[i]!=str_number[length-1-i])
        {
            Console.WriteLine($"The number {int_number} is not polindrome");
            break;
        }
        count++;
        
    }

    if(count == (length / 2)) 
    {
        
        Console.WriteLine($"The number {int_number} is polindrome");
        break;
    }
}

