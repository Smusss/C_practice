/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число от 1 до 7 (соответствие дням недели, где 1 - это Понедельник): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("Число не соответствует параметру, попробуйте еще раз.");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да, это выходной день.");
    }
    else
    {
        Console.WriteLine("Нет, это не выходной, число соответствует рабочему дню недели.");
    }
}