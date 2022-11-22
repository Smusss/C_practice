// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
// Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.

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

Console.Write("Input element index (m - row) = ");
int mInput = Convert.ToInt32(Console.ReadLine());
Console.Write("Input element index (n - column) = ");
int nInput = Convert.ToInt32(Console.ReadLine());

int[,] tableRandom = FillTableRandomInt(); // создание массива рандомного размера до 10*10 и рандомное наполнение числами от 0 до 9.
if (mInput > tableRandom.GetLength(0) || mInput < 0 || nInput > tableRandom.GetLength(1) || nInput < 0)
{
    Console.WriteLine("There is no element in the array at that position.");
}
else
{
    Console.WriteLine($"Element at that position ({mInput}, {nInput}) is {tableRandom[mInput, nInput]}.");
}

Console.WriteLine("Filled random array for check:"); // вывод массива для проверки ответа
PrintTable(tableRandom);