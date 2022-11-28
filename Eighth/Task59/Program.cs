// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая запишет нулями строку и столбец, на пересечении которых расположен наименьший элемент массива.

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
int[] MinNumber(int[,] table)
{
    int[] indexMin = new int [2] { 0, 0 };
    int min = table[0, 0];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i, j] < min)
            {
            min = table[i, j];
            indexMin[0] = i;
            indexMin[1] = j;
            }
        }
    }
    return indexMin;
}
int[,] tableResultZero(int[,] table, int iMin, int jMin)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        table[i, jMin] = 0;
    }

    for (int j = 0; j < table.GetLength(1); j++)
    {
        table[iMin, j] = 0;
    }
    return table;
}

Console.WriteLine("Table start:");
int[,] tableStart = FillRandomTable();
PrintTable(tableStart);
int [] indexMin = MinNumber(tableStart);
int iMin = indexMin[0];
int jMin = indexMin[1];
int[,] tableResult = tableResultZero(tableStart, iMin, jMin);
Console.WriteLine("Table result:");
PrintTable(tableResult);

