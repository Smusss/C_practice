// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Find the number of even and odd array elements");

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
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
int searchEvenElements(int[] array) // поиск  и подсчет четных элементов
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

string message = "Input array length:";
bool statusLength = inputLengthAndCheck(message, out int length);
if (!statusLength||length == 0)
{
    Console.WriteLine("Three attempts to enter the array length incorrectly.");
}
else
{
    int[] array = fillArrayRandom(length);
    int countEven = searchEvenElements(array);
    Console.WriteLine($"Number of even array elements: {countEven}");
}