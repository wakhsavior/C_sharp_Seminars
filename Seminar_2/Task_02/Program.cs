// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void PrintArray(int[] col){

    int count = col.Length;
    int position = 0;
    while(position < count){

        Console.WriteLine(col[position]);
        position++; 
    }
}

int count = 0;

while(count < 3){

    int number = new Random().Next(100,1000000);

     Console.WriteLine($"Random number: {number}");
    int arraylength = 0;
    int digits = number;
    while (digits != 0){
        digits = digits / 10;
        arraylength++;
    }
    int[] arraydigit = new int[arraylength];

//    Console.WriteLine(arraylength);
    
    for (int i = 0; i < arraylength; i++ ){
        arraydigit[i] = number % 10;
        number = number / 10;
        // Console.Write($"{arraydigit[i]} : {number} / ");
      
    }
    // PrintArray(arraydigit);
    Console.WriteLine($"{arraydigit[2]}{arraydigit[0]}");
    count++;
}