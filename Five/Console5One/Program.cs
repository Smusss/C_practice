//массив из 12 чисел от 9 до -9, найти сумму положиельных и сумму отриц

int[] array = new int[12];
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.WriteLine(array[i] + " ");
}
int sumPlus = 0;
int sumMinus = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPlus = sumPlus + array[i];
    }
    else
    {
        sumMinus = sumMinus + array[i];
    }
}
Console.WriteLine($"Sum positive numbers = {sumPlus}");
Console.WriteLine($"Sum negative numbers = {sumMinus}");

Console.ReadKey();