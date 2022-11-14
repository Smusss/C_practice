// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)

int ReadAndCheckSymbol(string message)
{
    bool check = false;
    string? numberS = String.Empty;
    int numberI = 0;
    do
    {
        Console.Write(message);
        numberS = Console.ReadLine();
        check = Int32.TryParse(numberS, out numberI);
        if (!check)
        {
            Console.WriteLine("Введено неверное значение, попробуйте еще раз.");
        }
    }
    while (!check);
    return numberI;
}

string message = "Введите число A: ";
int A = ReadAndCheckSymbol(message);
message = "Введите число B: ";
int B = ReadAndCheckSymbol(message);

double PowA = 1;
if (B == 0)
{
    Console.WriteLine($"Число {A} в степени {B} равно {PowA}");
}
else
{
    for (int i = 0; i < Math.Abs(B); i++)
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