/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int checkLength(string message) // ввод и проверка размерности (символ и отриц значение)
{
    int count = 3; // число попыток
    bool check = false;
    int length = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write(message);
        check = int.TryParse(Console.ReadLine(), out length);
        if (!check || length <= 0)
        {
            if (i == count - 1)
            {
                Console.WriteLine($"Ошибка! {count} попытки ввода некорректного значения. Запустите программу снова.");
                length = 0;
            }
            else
            {
                Console.WriteLine("Введено некорректное значение (символ), попробуйте еще раз.");
            }
        }
        else
        {
            i = count;
        }
    }
    return length;
}
int checkMark(string message) // ввод и проверка элементов массива (символ)
{
    int count = 3; // число попыток
    bool check = false;
    int number = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write(message);
        check = int.TryParse(Console.ReadLine(), out number);
        if (!check)
        {
            if (i == count - 1)
            {
                Console.WriteLine($"Ошибка! {count} попытки ввода некорректного значения. Элементу массива автоматически присвоено значение 0.");
            }
            else
            {
                Console.WriteLine("Введено некорректное значение (символ), попробуйте еще раз.");
            }
        }
        else
        {
            i = count;
        }
    }
    return number;
}

string message = "Введите размерность массива (число элементов): ";  // оставила возможность ввода количества элементов массива
int length = checkLength(message);
if (length == 0)
{
    Console.Write("Введено некорректное значение размерности массива.");
}
else
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        message = $"Введите элемент массива № {i + 1}: ";
        array[i] = checkMark(message);
    }
    Console.Write("Введен массив: ");
    for (int i = 0; i < length; i++)
        if (i == length - 1)
        {
            Console.Write(array[i] + ".");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
}