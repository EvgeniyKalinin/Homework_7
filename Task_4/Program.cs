void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}

void SortMatrix(int[,] matr)
{
    int indexMin1 = 0;
    int indexMin2 = 0;
    int s2 = 0;

    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            int count = 0;
            int min = matr[x, y];
            int s1 = x;
            for (int i = s1; i < matr.GetLength(0); i++)
            {
                if (count == 0)
                {
                    s2 = y;
                }
                else
                {
                    s2 = 0;
                }
                for (int j = s2; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] <= min)
                    {
                        indexMin1 = i;
                        indexMin2 = j;
                        min = matr[i, j];
                    }

                }
                count = 1;
            }
            int save = matr[x, y];
            matr[x, y] = matr[indexMin1, indexMin2];
            matr[indexMin1, indexMin2] = save;
        }
    }
}

Console.WriteLine("Введите число строк.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов.");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

FillArray(matrix);
Console.WriteLine();
Console.WriteLine($"Матрица {n} x {m}, заполненная случайными числами:");
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
SortMatrix(matrix);
Console.WriteLine("Матрица после сортировки:");
Console.WriteLine();
PrintArray(matrix);
