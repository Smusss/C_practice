// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int[] SumOfElementsInRows(int[,] table)
{
    int[] arraySum = new int[table.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum = sum + table[i, j];
        }
        arraySum[i] = sum;
        sum = 0;
    }
    return arraySum;
}
int MinimalSumOfRows(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}

int[,] table = FillRandomTable();
Console.WriteLine("Random table:");
PrintTable(table);
int[] arraySumNumbersOfRows = SumOfElementsInRows(table);
int rowNumber = MinimalSumOfRows(arraySumNumbersOfRows);
Console.WriteLine($"Row with minimum sum of elements: {rowNumber}");