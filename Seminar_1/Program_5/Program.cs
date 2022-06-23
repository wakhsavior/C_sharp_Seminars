// Написать программу находящую последнее число в 3-х значном числе. Включить проверку на то, что число 3-х значное
int Number = 0;
do { 
    Console.Write("Enter Number XXX: ");
    Number = Convert.ToInt32(Console.ReadLine());
    if (Number >= 100 && Number <= 999){
        Console.Write("The last Number is: " + Number%10);
    } 

} while((Number <100) || (Number > 999));