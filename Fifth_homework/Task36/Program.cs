// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Sum of elements in odd positions");


bool inputLengthAndCheck(string message, out int length) // проверка корректности ввода размера массива
{
    bool check = false;
    int count = 3;
    length = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write(message);
        string? numberStr = Console.ReadLine();
        check = int.TryParse(numberStr, out int result);
        if (!check || result <= 0)
        {
            Console.WriteLine("Uncorrect input.");
        }
        else
        {
            i = count;
            length = result;
        }
    }
    return check;
}
int[] fillArrayRandom(int length) //заполнение трехзн и + числами, вывод массива
{
    Console.Write("Array: ");
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next();
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
long sumElementsOddPosition(int[] array) // расчет суммы элементов на нечетных позициях !!! long
{
    long sum = 0; // long т.к при сложении int выдает ошибку (переполнение)
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

string message = "Input array length:";
bool statusLength = inputLengthAndCheck(message, out int length);
if (!statusLength || length == 0)
{
    Console.WriteLine("Three attempts to enter the array length incorrectly.");
}
else
{
    int[] array = fillArrayRandom(length);
    long sum = sumElementsOddPosition(array);
    Console.WriteLine($"Sum of elements in odd positions = {sum}");
}