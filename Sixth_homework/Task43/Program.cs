// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNumber(string message)
{
    Console.Write($"Input {message}: ");
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void checkLines(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Direct match.");
        }
        else
        {
            Console.WriteLine("Parallel lines.");
        }
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Dot ({x}, {y}).");
    }

}

string message = "k1";
double k1 = InputNumber(message);
message = "b1";
double b1 = InputNumber(message);
message = "k2";
double k2 = InputNumber(message);
message = "b2";
double b2 = InputNumber(message);

checkLines(k1, k2, b1, b2);