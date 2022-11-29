// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. (без словаря)
// TODO
int[,] FillRandomTable()
{
    int m = new Random().Next(1, 10);
    int n = new Random().Next(1, 10);
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
int CountDoubles(int n, int[,] table)
{
    int repeat = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (n == table[i, j])
            {
                repeat++;
            }
        }
    }
    return repeat;
}
void PrintRepeats(int[,] table)  // TO DO: дополнить сортировкой и выводом без дублей
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            int n = table[i, j];
            int repeatN = CountDoubles(n, table);

            Console.WriteLine($"{table[i, j]} repeats {repeatN} times.");
        }
    }
}

int [,] table = FillRandomTable();
PrintTable(table);
Console.WriteLine();
PrintRepeats(table);
