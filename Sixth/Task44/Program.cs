// вывести первые N чисел Фибоначчи без использования рекурсии и метода
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < n; i++)
{
    array[i] = array[i-1] + array[i-2];
}
 Console.WriteLine();
for (int i = 0; i < n;i++)
{
    Console.Write(array[i] + " ");
}