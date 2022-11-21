//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int M = new Random().Next(5, 10);
int count = 0;
for (int i = 1; i <= M; i++)
{
Console.Write($"Введите число №{i}: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
{
    count++;
}
}
Console.WriteLine();
Console.Write($"Amount of positive numbers = {count}");