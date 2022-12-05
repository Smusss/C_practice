//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akkerman(int m, int n)
{
    int result = 0;
    if (m == 0)
    {
        result = n + 1;
        return result;
    }
    else
    {
        if (m > 0 && n == 0)
        {
            result = Akkerman(m - 1, 1);
            return result;
        }
        else
        {
            if (m > 0 && n > 0)
            {
                result = Akkerman(m - 1, Akkerman(m, n - 1));
                return result;
            }
        }
    }
    return result;
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
{
    Console.WriteLine("Incorrect input. Try again");
}
else
{
    int result = Akkerman(m, n);
    Console.WriteLine($"Result = {result}");
}