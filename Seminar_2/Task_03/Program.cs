// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter first number: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if ((firstnumber % secondnumber) == 0){
    Console.WriteLine($"Number {firstnumber} is a multiple of a {secondnumber} ");
}
else {
    Console.WriteLine($"The remainder of the division {firstnumber} to {secondnumber} is {firstnumber%secondnumber}");
}