/* Week
 Напишите программу, которая будет выдавать название дня недели по заданному номеру.*/
 Console.Write("Введите число от 1 до 7: ");
 int number = Convert.ToInt32(Console.ReadLine());
if (number <1 | number >7) Console.Write("Введено значение, не соответствующее интервалу, попробуйте еще раз!");
if (number == 1) Console.Write("It is Monday");
if (number == 2) Console.Write("It is Tuesday");
if (number == 3) Console.Write("It is Wednesday");
if (number == 4) Console.Write("It is Thursday");
if (number == 5) Console.Write("It is Friday");
if (number == 6) Console.Write("It is Saturday");
if (number == 7) Console.Write("It is Sunday");
