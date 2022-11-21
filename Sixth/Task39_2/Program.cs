// переворот массива с использованием доп переменной

int[] array = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
int temp = 0;
Console.Write("Array Turn: ");
for (int i = 0; i < array.Length; i++)
{
    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
    Console.Write(array[i] + " ");
}
Console.ReadLine();