
int[] storoni = { 3, 10, 8 };
int perimetr = 0;
for (int i = 0; i < storoni.Length; i++)
{
    perimetr += storoni[i];
}

bool treugolnik = true;

for (int i = 0; i < storoni.Length; i++)
{
    if (storoni[i] > perimetr - storoni[i])
    {
        treugolnik = false;
        break;
    }
}

Console.WriteLine(treugolnik);