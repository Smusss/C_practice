/* Even numbers between zero and N
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
int evenN = 2;
Console.Write("Четные числа от 1 до N: ");
while (evenN <= N)
{
    Console.Write(evenN + " ");
    evenN = evenN + 2;
}
}
else
{
  int evenN = 0;
while (evenN >= N)
{
    Console.Write(evenN + " ");
    evenN = evenN - 2;
}  
}
