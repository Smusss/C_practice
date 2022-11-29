// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] FillRandomTableFixColumn(int m)
{
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
int ElementCalculation(int i, int j, int[,] table1, int[,] table2)
{
    int number = 0;
    for (int m = 0; m < table1.GetLength(1); m++)
    {
        {
            number = number + table1[i, m] * table2[m, j];
        }
    }
    return number;
}
int[,] ProductOfTwoMatrix(int[,] table1, int[,] table2)
{
    int[,] tableResult = new int[table1.GetLength(0), table2.GetLength(1)];
    for (int i = 0; i < tableResult.GetLength(0); i++)
    {
        for (int j = 0; j < tableResult.GetLength(1); j++)
        {
            tableResult[i, j] = ElementCalculation(i, j, table1, table2);
        }
    }
    return tableResult;
}

int[,] matrixOne = FillRandomTable();
Console.WriteLine("First matrix:");
PrintTable(matrixOne);
int m = matrixOne.GetLength(1);
int[,] matrixTwo = FillRandomTableFixColumn(m);
Console.WriteLine("Second matrix:");
PrintTable(matrixTwo);
int[,] matrixResult = ProductOfTwoMatrix(matrixOne, matrixTwo);
Console.WriteLine("Result matrix:");
PrintTable(matrixResult);