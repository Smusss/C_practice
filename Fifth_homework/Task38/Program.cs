// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
double [] fillArrayRandom(int length) //заполнение вещественными числами, вывод массива
{
    Console.Write("Array: ");
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble();
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
double diffBetweenMaxAndMin(double[] array) // поиск  макс и мин элементов и разности между ними
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

string message = "Input array length:";
bool statusLength = inputLengthAndCheck(message, out int length);
if (!statusLength || length == 0)
{
    Console.WriteLine("Three attempts to enter the array length incorrectly.");
}
else
{
    double[] array = fillArrayRandom(length);
    double diff = diffBetweenMaxAndMin(array);
    Console.WriteLine($"Difference between max and min = {diff}");
}