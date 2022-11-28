// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] FillRandomTable()
{
    int n = new Random().Next(0, 10);
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
int[,] ChangeFirstAndLastRow(int[,] table)
{
    int temp = 0;
    int i = 0;
    int k = table.GetLength(0) - 1;
    for (int j = 0; j < table.GetLength(1); j++)
    {
        temp = table[i, j];
        table[i, j] = table[k, j];
        table[k, j] = temp;
    }
    return table;
}

int[,] tableStart = FillRandomTable();
Console.WriteLine("Table start:");
PrintTable(tableStart);
int [,] tableChange = ChangeFirstAndLastRow(tableStart);
Console.WriteLine("Table change:");
PrintTable(tableChange);
