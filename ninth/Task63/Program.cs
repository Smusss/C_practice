//  Задайте значение N. Напишите программу, которая выведет  все натуральные числа в промежутке от N до 1.
int Numbers(int n)
{
    if (n == 0)
    {
        return 0;
    }
    int result = Numbers(n - 1);
    Console.Write(n + " ");
    return result;
}

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Num = Numbers(n);