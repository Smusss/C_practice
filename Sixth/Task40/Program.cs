// принять с клавиатуры три числа и проверить возможен ли треугольник со сторонами такой длины
// Треугольник можно построить в том случае, если сумма длин двух любых его сторон больше длины третьей стороны.

bool inputAndCheckNumber(string message, out int number)
{
    bool check = false;
    int count = 3; // число попыток ввода
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write(message);
        string? numberStr = Console.ReadLine();
        check = int.TryParse(numberStr, out result);
        if (!check || result <= 0)
        {
            Console.WriteLine("Incorrect input.");
            check = false;
        }
        else
        {
            i = count;
        }
    }
    number = result;
    return check;
}
bool checkTriangle(int A, int B, int C)
{
 bool check = (A > (B + C) && B > (A + C) && C > (A + B));
 return check;
}

string message = "Введите длину первой стороны A: ";
bool checkA = inputAndCheckNumber(message, out int A);
message = "Введите длину первой стороны B: ";
bool checkB = inputAndCheckNumber(message, out int B);
message = "Введите длину первой стороны C: ";
bool checkC = inputAndCheckNumber(message, out int C);
bool check = checkTriangle(A, B, C);
if (!checkA || !checkB || !checkC)
{
    Console.WriteLine("Try again.");
}
else
{
   if (!check)
   {
    Console.WriteLine("Imrossible.");
   }
   else
   {
     Console.WriteLine("You can build a triangle.");
   }
}