//замена элементов с положительных на отриц и наоборот

void showNumbers (int[] array)
{
  for (int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
}
}
Console.Write("Исходный массив: ");
int [] array = new int [8] {0, 1, 2, 3, 4, -1, -2, -3};

for (int i = 0;i < array.Length; i++)
{
    {
        Console.Write(array[i] + " ");
        array[i] = array[i] * -1;
    }
}
Console.WriteLine("");
Console.Write("Откорректированный массив: ");
showNumbers(array);
