// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)
bool check = false;
string As = String.Empty;
string Bs = String.Empty;

do
{
    Console.Write("Введите число A: ");
    As = Console.ReadLine();
    check = Double.TryParse(As, out double Ad);
    if (check == false)
    {
       Console.WriteLine("Введено неверное значение, попробуйте еще раз.");
    }
}
while (check == false);
//double A = Convert.ToDouble(Console.ReadLine());

do
{
    Console.Write("Введите число B: ");
    Bs = Console.ReadLine();
    check = Double.TryParse(Bs, out double Bd);
    if (check == false)
    {
        Console.WriteLine("Введено неверное значение, попробуйте еще раз.");
    }
}
while (check == false);
//double B = Convert.ToDouble(Console.ReadLine());

double A = Convert.ToDouble(As);
double B = Convert.ToDouble(Bs);

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