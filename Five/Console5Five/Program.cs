// наяти произведения пар чисел. Пара - первый и последний, второй и предпосл и т.д
Console.Write("Input array length: ");
bool check = int.TryParse(Console.ReadLine(), out int inputLength);
if (!check || inputLength <= 0)
{
    Console.Write("Uncorrect input. Try again.");
}
else
{
    int[] arrayStart = new int[inputLength];
    Console.Write("Array Start: ");
    for (int i = 0; i < arrayStart.Length; i++)
    {
        arrayStart[i] = new Random().Next(0, 10);
        Console.Write(arrayStart[i] + " ");
    }

    Console.WriteLine("");
    Console.Write("Array Finish: ");
    int[] arrayFinish = new int[arrayStart.Length / 2 + arrayStart.Length % 2];
    if (arrayStart.Length % 2 == 0)
    {
        for (int i = 0; i < arrayFinish.Length; i++)
        {
            arrayFinish[i] = arrayStart[i] * arrayStart[arrayStart.Length - 1 - i];
            Console.Write(arrayFinish[i] + " ");
        }
    }
    else
    {
        for (int i = 0; i < arrayFinish.Length; i++)
        {
            if (i == arrayFinish.Length - 1)
            {
                arrayFinish[i] = arrayStart[i];
                Console.Write(arrayFinish[i]);
            }
            else
            {
                arrayFinish[i] = arrayStart[i] * arrayStart[arrayStart.Length - 1 - i];
                Console.Write(arrayFinish[i] + " ");
            }
        }
    }
}