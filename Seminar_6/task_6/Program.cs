Fibonacci:
int N = 8;
for (int i = 0; i < N; i++)
{
    int member = i < 2 ? i : 2 * i - 3;
    Console.Write($" {member} ");
}
