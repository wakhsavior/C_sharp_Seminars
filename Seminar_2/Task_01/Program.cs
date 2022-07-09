/* Написать программу, которая выводит число из отрезка [10,99] и показать наибольшую цифру числа

*/

int count = 0;

while (count < 10){

    int number = new Random().Next(10,100);

    Console.WriteLine($"Random number: {number}");
    int digitone = number / 10;
    int digittwo = number % 10;    

    int max = Math.Max(digitone, digittwo);

    Console.WriteLine($"Max number: {max}");
    // if (digitone > digittwo) {
    //     Console.WriteLine($"Digit one {digitone} > digit two {digittwo}");
    // }
    // else if (digitone < digittwo) {
    //     Console.WriteLine($"Digit two {digittwo} > digit one {digitone}");
    // }
    // else {
    //     Console.WriteLine($"Digit one {digitone} = digit two {digittwo}");

    // }
    count++;
}

