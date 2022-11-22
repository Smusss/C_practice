// Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
// Округлите значения, генерируемые Random до двух знаков после запятой.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillTableRandomNumbers(int m, int n)
{
    double[,] table = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            table[i, j] = Math.Round(new Random().NextDouble(),2);
        }
    }
    return table;
}
void PrintTable(double[,] table)
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

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] RandomTable = FillTableRandomNumbers(m, n);
PrintTable(RandomTable);