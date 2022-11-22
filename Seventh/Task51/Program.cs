// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] FillQuatroTableRandomNumbers(int n) // заполнение массива заданной размерности рандомными числами от 1 до 9
{
    int[,] table = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            table[i, j] = new Random().Next(0, 10);
        }
    }
    return table;
}
int sumDiagonal(int[,] table)
{
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + table[i, j];
            }
        }
    }
    return sum;
}
void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] table = FillQuatroTableRandomNumbers(n);
Console.WriteLine("Table:");
PrintTable(table);
int sumDiag = sumDiagonal(table);
Console.Write($"Sum of diagonal elements = {sumDiag}");