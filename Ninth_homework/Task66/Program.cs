// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumBetween(int m, int n)
{
    if (n - m <= 1)
    {
        return 0;
    }
    return m + 1 + SumBetween(m + 1, n);
}
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < m)
{
    int temp = n;
    n = m;
    m = temp;
}
int sum = SumBetween(m, n);
Console.Write($"Sum elements between= {sum}");