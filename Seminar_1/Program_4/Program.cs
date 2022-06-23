// Написать программу, которая выводит числа -N до N при заданном N

Console.Write("Enter Number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int i = Number * (-1);
while (i <= Number){
    Console.WriteLine(i);
    i += 1;
}
