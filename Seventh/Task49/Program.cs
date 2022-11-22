// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


int[,] FillTableRandomInt()
{
    int m = new Random().Next(1, 11); // случайное количество строк от 1 до 10
    int n = new Random().Next(1, 11); // случайное количество столбцов от 1 до 10
    int[,] table = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            table[i, j] = new Random().Next(0, 10); // случайное число до 10
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
int[,] changeTableElements(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                table[i, j] = table[i, j] * table[i, j];
            }
        }
    }
    return table;
}
int[,] randomTable = FillTableRandomInt();
Console.WriteLine("Table start:");
PrintTable(randomTable);
Console.WriteLine("Table changed:");
int[,] changedTable = changeTableElements(randomTable);
PrintTable(changedTable);
