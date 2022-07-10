// while (true)
// {
//     Console.Write("Enter number 5-digits: ");
//     string str = Console.ReadLine();
//     try
//     {
//         int number = Convert.ToInt32(str);
//         if (number > 9999 && number < 100000) break;
//     }
//     catch
//     {
//         Console.WriteLine("Wrong data. Try again: ");
//         continue;
//     }
//     Console.WriteLine("Wrong data. Try again: ");
// }

// //TryParse

string test = "12345f"; 
int result = 0;

Console.WriteLine(int.TryParse(test, out result));
Console.WriteLine(result);