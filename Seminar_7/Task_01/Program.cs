int rows = Int32.Parse(Console.ReadLine());
int columns = Int32.Parse(Console.ReadLine());

int[,] matrix = new int[rows,columns];

for(int i=0;i<matrix.GetLength(0);i++)
{
    for (int j=0;j<matrix.GetLength(1);j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+ "\t");
    }
    Console.WriteLine();

}

