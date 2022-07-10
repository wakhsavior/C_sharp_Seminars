// int[] array = {1,2,3,4,5};
// int[] testArray = new int[5];

// Console.WriteLine(array);

// Console.WriteLine($"{String.Join("; ", array)}");

int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i = 0;
// for (int i = 0; i <= A; i++)
// {
//     sum+=i;
// }

while(i<A)
{
    sum+=i;
    i++;
}

Console.WriteLine(sum);