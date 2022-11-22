// Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами. 
// Напишите метод для поиска ср. арифметического значения каждого столбца.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillTableRandomNumbers(int m, int n) // заполнение массива заданной размерности рандомными числами от 1 до 9
{
    int[,] table = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            table[i, j] = new Random().Next(0, 10);
        }
    }
    return table;
}
void PrintTable(int[,] table) // вывод сформированного массива
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
double[] averageOfEveryColumns(int[,] table) // формирование массива из значений среднего арифм. каждого столбца заданного массива
{
    double[] array = new double[table.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = 0; k < table.GetLength(0); k++)
        {
            sum = sum + table[k,i];
        }
        array[i] = Math.Round(sum / Convert.ToDouble(table.GetLength(0)), 1);
        sum = 0;
    }
    return array;
}
void PrintArray(double[] array) // вывод массива средних значений
{
    Console.Write("Average of every colomn: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +"; ");
    }
}

Console.Write("Input m (row): "); // ввод количества строк
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input n (column): "); // ввод количества столбцов
int n = Convert.ToInt32(Console.ReadLine());

int[,] RandomTable = FillTableRandomNumbers(m, n);
PrintTable(RandomTable);
double[] averageColumns = averageOfEveryColumns(RandomTable);
PrintArray(averageColumns);