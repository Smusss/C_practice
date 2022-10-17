/*   An even or odd
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/
Console.Write("Введите целое число: ");
Int64 number = Convert.ToInt64(Console.ReadLine());
Int64 result = 0;
Math.DivRem(number,2,out result);
if (result == 0)
{
   Console.Write("Число " + number + " четное"); 
}
else
{
    Console.Write("Число " + number + " нечетное"); 
}