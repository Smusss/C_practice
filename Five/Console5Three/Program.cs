// задать массив и определить присутствует ли число в массиве. метод обязательно!

bool InputNumAndCheckSymb(string message, out int number)
{
    bool check = false;
    int count = 3;
    number = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write(message);
        string? numberStr = Console.ReadLine();
        check = int.TryParse(numberStr, out int result);
        if (!check)
        {
            Console.WriteLine("Uncorrect input.");
        }
        else
        {
            i = count;
            number = result;
        }
    }
    return check;
}
bool findSameNumber(int[] array, int number)
{
    bool findSame = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            findSame = true;
            break;
        }
    }
    return findSame;
}
int[] array = new int[10] { 1, 16, 2, 277, 3, 98, 4, 56, 5, -963 };
string message = "Input your number: ";
bool status = InputNumAndCheckSymb(message, out int inputNumber);
if (!status)
{
    Console.WriteLine("Uncorrect input by 3 chance");
}
else
{
    bool findSame = findSameNumber(array, inputNumber);
    if (!findSame)
    {
        Console.WriteLine("There is not the same number in array.");
    }
    else
    {
        Console.WriteLine("There is the same number in array.");
    }
}