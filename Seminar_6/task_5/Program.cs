// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Binary(int number)
{
    string result = "";
    while(number>0)
    {
        result = number%2 + result;
        number/=2;
    }
   Console.WriteLine(result);
    
}

int N = 192;


// int[] booldigitals= new int [32];
// int i = 0;

// while (N !=0)
// {
//     booldigitals[booldigitals.Length-1-i] = N%2;
//     N= N/2;
//     i++;
// }

Binary(N);

