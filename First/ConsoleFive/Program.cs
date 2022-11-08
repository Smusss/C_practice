/*The last number in three-digit number
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.*/

Console.Write("Введите трехзначное число: ");
int input = Convert.ToInt32(Console.ReadLine());
int number = Math.Abs(input);
int last = 0;
if (number > 999 | number < 100)
{
    Console.WriteLine("Значение не соответствет запросу, попробуйте снова.");
}
else
{
    last = number % 10;
    Console.WriteLine($"Последняя цифра числа {input} это {last}");
}