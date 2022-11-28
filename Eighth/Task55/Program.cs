// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillRandomTable(int m, int n)
{
    int[,] table = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            table[i, j] = new Random().Next(0, 10);
        }
    }
    return table;
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
int[,] ReplaceRowsAndColumns(int[,] table)
{
    int temp = 0;
    for (int i = 0; i < table.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < table.GetLength(1); j++)
        {
            temp = table[i, j];
            table[i, j] = table[j, i];
            table[j, i] = temp;
        }
    }
    return table;
}

Console.Write("Input amount of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of columns:");
int n = Convert.ToInt32(Console.ReadLine());
if (m != n)
{
    Console.WriteLine("Replace is impossible. Amount of rows and columns is not the same");
}
else
{
    int[,] tableStart = FillRandomTable(m, n);
    Console.WriteLine("Table start:");
    PrintTable(tableStart);
    int[,] tableReplace = ReplaceRowsAndColumns(tableStart);
    Console.WriteLine("Table replace:");
    PrintTable(tableReplace);
}