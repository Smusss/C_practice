// Переворот массива

int[] inputLengthAndFillArray(string message)
{
    Console.Write(message);
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    Console.Write("Array: ");
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write(array[i] + " ");
    }
        return array;
}

int[] turnArray(int[] array)
{
    int[] arrayTurn = new int[array.Length];
    Console.Write("Array Turn: ");
    for (int i = 0; i < array.Length; i++)
    {
        arrayTurn[i] = array[array.Length - 1 - i];
        Console.Write(arrayTurn[i] + " ");
    }
    return arrayTurn;
}
string message = "Input array lenth: ";
int[] array = inputLengthAndFillArray(message);
Console.WriteLine();
int[] arrayTurn = turnArray(array);