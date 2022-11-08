// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

string GetCoordinate(int quarter)
{
    string Coord = "x & y";
    if (quarter == 1)
    {
        Coord = "x > 0, y > 0";
    }
    if (quarter == 2)
    {
        Coord = "x < 0, y > 0";
    }
    if (quarter == 3)
    {
        Coord = "x < 0, y < 0";
    }
    if (quarter == 4)
    {
        Coord = "x > 0, y < 0";
    }
    return Coord;
}

Console.Write("Введите номер четверти от 1 до 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter > 4 || quarter < 1)
{
    Console.WriteLine("Число не соответствует заданному параметру, попробуйте еще раз");
}
else
{
    string coordinate = GetCoordinate(quarter);
    Console.WriteLine($"Допустимые значения x и y в соответствии с заданной четвертью {coordinate}");
}