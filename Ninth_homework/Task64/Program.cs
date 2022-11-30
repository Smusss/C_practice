//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

int NumbersBetween(int m, int n)
{
    Console.Write(m + " ");
    if (m == n)
    {
        return n;
    }
    return NumbersBetween(m + 1, n);
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
int Num = NumbersBetween(m,n);

Console.WriteLine();
Console.WriteLine();

void Between(int k, int l)
{
    Console.Write(k + " ");
    if (k == l)
    {
        return;
    }
   NumbersBetween(k + 1, l);
}
Console.Write("Input K: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Input L: ");
int l = Convert.ToInt32(Console.ReadLine());
if (l < k)
{
    int temp = l;
    l = k;
    k = temp;
}
Between(k,l);