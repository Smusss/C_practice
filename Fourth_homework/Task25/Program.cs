// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)
bool check = false;
string As = string.Empty;
string Bs = string.Empty;

do
{
    Console.Write("Введите число A: ");
    As = Console.ReadLine();
    check = double.TryParse(As, out double As);
    if (check)
    {
        Double.Parse(As, out double A);
    }
    else
    {
        Console.WriteLine("Введено неверное значение, попробуйте еще раз.");
    }
}
while (check == false);
//double A = Convert.ToDouble(Console.ReadLine());

do
{
    Console.Write("Введите число B: ");
    B = Console.ReadLine();
    Double.TryParse(B, out double B);
    if (Double.TryParse(B, out double B) == false)
    {
        Console.WriteLine("Введено неверное значение, попробуйте еще раз.");
    }
}
while (Double.TryParse(B, out double B) == false);
//double B = Convert.ToDouble(Console.ReadLine());

double PowA = 1;
int i = 1;
if (B == 0)
{
    Console.WriteLine($"Число {A} в степени {B} равно {PowA}");
}
else
{
    for (i = 1; i <= Math.Abs(B); i++)
    {
        PowA = PowA * A;
    }

    if (B < 0)
    {
        Console.WriteLine($"Число {A} в степени {B} равно 1/{PowA} ({1 / PowA})");
    }
    else
    {
        Console.WriteLine($"Число {A} в степени {B} равно {PowA}");
    }
}