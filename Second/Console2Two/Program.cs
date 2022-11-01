/* Напишите программу, которая будет принимать на 
вход два числа и выводить, является ли второе число 
кратным первому. Если число 2 не кратно числу 1, то 
программа выводит остаток от деления.*/

Console.Write("Введите первое число = ");
int number1 = Convert.ToInt32(Console.ReadLine());

NumberTwo:
Console.Write("Введите второе число = ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == 0)
{
    Console.WriteLine("Второе число не должно быть равно нулю, введите заново");
    //Console.Write("Введите второе число = ");
   // number2 = Convert.ToInt32(Console.ReadLine());
    goto NumberTwo;
}

if (number1 % number2 == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    int balance = number1 % number2;
    Console.WriteLine("Первое число не кратно второму.");
    Console.WriteLine($"Остаток от деления составляет: = + {balance}");
}