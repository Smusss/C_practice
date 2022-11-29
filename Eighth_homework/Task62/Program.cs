// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
int[,] FillSpiral(int m)
{
    int[,] table = new int[m, m];
    int n = 1; // стартовое значение
    int i = 0;
    int j = 0;
    int up = 0; // отступы с каждой стороны
    int down = 0;
    int left = 0;
    int right = 0;
    while (n <= m * m) // пока значение не достигнет кв м
    {
        i = up;
        for (j = left; j < table.GetLength(1) - right; j++) // 1 увел столб, фикс строку
        {
            table[i, j] = n;
            n++;
        }
        up++;   // увеличивает соотв отступ
        j = table.GetLength(1) - 1 - right;
        for (i = up; i < table.GetLength(0) - down; i++) // 2 увел строку, фикс столб
        {
            table[i, j] = n;
            n++;
        }
        right++;
        i = table.GetLength(0) - 1 - down;
        for (j = table.GetLength(1) - 1 - right; j >= left; j--)   // 3 уменьш столб, фикс строку
        {
            table[i, j] = n;
            n++;
        }
        down++;
        j = left;
        for (i = table.GetLength(0) - 1 - down; i >= up; i--)  // 4 уменьш строку, фикс столб
        {
            table[i, j] = n;
            n++;
        }
        left++;
    }
    return table;
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] table = FillSpiral(m);
PrintTable(table);