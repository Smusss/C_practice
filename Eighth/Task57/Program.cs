// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[,] table = FillRandomTable();
Console.WriteLine("Inputed table:");
PrintTable(table);
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (!dict.ContainsKey(table[i, j]))
        {
            dict.Add(table[i, j], 1);
        }
        else
        {
            dict[table[i, j]]++;
        }
    }
}

foreach (var dic in dict)
{
    Console.WriteLine($"{dic.Key} встречается {dic.Value} раз.");
}
