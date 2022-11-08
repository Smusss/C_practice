/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void PrintCube(int N)
{
    int i = 0;
    for (i = 1; i <= N; i++)
        Console.Write(i * i * i + " ");
}
Console.Write("Введите число N (больше нуля): ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    Console.Write("Число не соответствует параметру. Попробуйте снова");
}
else
{
    PrintCube(N);
}