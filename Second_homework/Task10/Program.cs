/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Input:
Console.Write("Введите трехзначное число = ");
int number = Convert.ToInt32(Console.ReadLine());

if ((Math.Abs(number) > 999)||(Math.Abs(number) < 100))
{
    Console.WriteLine("Число не соответствует заданному параметру");
    goto Input;
}

int secondNumber = Math.Abs((number / 10) % 10);
Console.WriteLine($"Вторая цифра числа {number} это {secondNumber}");