// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillRandom3DArrayNoRepeat()
{
    int m = new Random().Next(1, 5);
    int n = new Random().Next(1, (100 - 10) / (2 * m));
    int k = new Random().Next(2, (100 - 10) / (m * n));
    int[,,] array3D = new int[m, n, k];
    HashSet<int> Unique = new HashSet<int>();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                int count = Unique.Count;
                array3D[i, j, l] = new Random().Next(10, 100);
                Unique.Add(array3D[i, j, l]);
                if (count - Unique.Count == 0)
                {
                    l--;
                }
            }
        }
    }
    return array3D;
}
void PrintArray3DWithIndex(int[,,] array3D)
{
    Console.WriteLine($"3D - array {array3D.GetLength(0)} x {array3D.GetLength(1)} x {array3D.GetLength(2)}.");
    for (int l = 0; l < array3D.GetLength(2); l++)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                {
                    Console.Write($"{array3D[i, j, l]} ({i}; {j}; {l}) ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,,] array3D = FillRandom3DArrayNoRepeat();
PrintArray3DWithIndex(array3D);