/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double AskAndCheckCoordinate(string message) // запрос координаты и ее проверка
{
Question: // ссылка для посторного запроса
    Console.Write($"{message}");
    string? Coord = Console.ReadLine();
       if (Double.TryParse(Coord, out double newCoord) == false) //если буква - повтор запроса 
    {
        Console.WriteLine("Некорректный ввод координаты. Введите число.");
        goto Question; // возврат к запросу координаты
    }
    else
    {
        return newCoord;
    }
}
double GetDistance(double xa, double ya, double za, double xb, double yb, double zb) // Расчет - расстояние между точками — это число, равное корню из суммы квадратов разностей координат точек или длине разности радиус-векторов точек.
{
    double dist = Math.Round(Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2)), 2);
    return dist;
}

string message = "Введите координату точки A по оси x: ";
double xa = AskAndCheckCoordinate(message);
message = "Введите координату точки A по оси y: ";
double ya = AskAndCheckCoordinate(message);
message = "Введите координату точки A по оси z: ";
double za = AskAndCheckCoordinate(message);
message = "Введите координату точки B по оси x: ";
double xb = AskAndCheckCoordinate(message);
message = "Введите координату точки B по оси y: ";
double yb = AskAndCheckCoordinate(message);
message = "Введите координату точки B по оси z: ";
double zb = AskAndCheckCoordinate(message);

double distance = GetDistance(xa, ya, za, xb, yb, zb);

Console.Write($"Расстояние между точками A и B с заданными вами координатами в трехмерном пространстве составляет {distance}");