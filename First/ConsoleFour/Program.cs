/* Range between -N and N
 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.*/
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -Math.Abs(N);
while (count <= Math.Abs(N))
{
    Console.Write(count + " ");
    count++;

}
