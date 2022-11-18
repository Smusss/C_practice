// задать одномерный массив из 123 случайных чисел. Найти количество элементов в отрезке от 10 до 99
int findAmountNumFromGivenFrames(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (10 < array[i] && array[i] < 99)
        {
            count++;
        }
    }
    return count;
}

int[] array123Random = new int[123];
for (int i = 0; i < array123Random.Length; i++)
{
    array123Random[i] = new Random().Next(1,150);
    Console.Write(array123Random[i] + " ");
}

int amount = findAmountNumFromGivenFrames(array123Random);
Console.WriteLine("");
Console.Write($"Amount of numbers from given frames = {amount}");