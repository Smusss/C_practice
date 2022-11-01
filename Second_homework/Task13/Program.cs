/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите число = ");
long number = Convert.ToInt64(Console.ReadLine());
long memory = number;
number = Math.Abs(number);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 1000)
    number = number / 10;
    int thirdNumber = Convert.ToInt32(number % 10);
    Console.WriteLine($"Третья цифра числа {memory} это {thirdNumber}");
}