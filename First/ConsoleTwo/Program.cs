/* Square check 
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго*/
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
Console.Write("Число " + a + " это квадрат числа " + b);
}
else
{
Console.Write("Число " + a + " не является квадратом числа " + b);
}