// преобразовать число из десятичной в двоичную. Обязательно через метод.


string GetBinary (int number)
{ 
string binary = string.Empty;
while (number > 0)
{
   binary = Convert.ToString(number % 2) + binary;
   number = number / 2;
}
return binary;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string binary = GetBinary(number);
Console.Write($"Число в двоичной системе: {binary}");