// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillRandomTable()
{
    int m = new Random().Next(0, 10);
    int n = new Random().Next(0, 10);
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
int[,] OrderRows(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1) - 1; j++)
        {
            if (table[i, j] < table[i, j + 1])
            {
                int tepm = table[i, j];
                table[i, j] = table[i, j + 1];
                table[i, j + 1] = tepm;
                j = 0 - 1;
            }
        }
    }
    return table;
}


int[,] table = FillRandomTable();
Console.WriteLine("Inputed table:");
PrintTable(table);
int[,] tableOrderRows = OrderRows(table);
Console.WriteLine("Table with ordered rows:");
PrintTable(tableOrderRows);