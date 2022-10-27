// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = new Random().Next(10,100);
// Console.ReadKey(); предотвращает закрытие консоли, у меня не так
Console.WriteLine(number);
int a1 = number / 10;
int a2 = number % 10;

if (a1 > a2)
{
    Console.WriteLine("Наибольшая цифра в числе: " + a1);
}
if (a2>a1)
{
    Console.WriteLine($"Наибольшая цифра в числе: {a2}");
}
if (a1==a2)
{
    Console.WriteLine("Цифры равны");
}