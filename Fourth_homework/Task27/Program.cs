/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Для решения задания использование цикла for является обязательным условием
452 -> 11 82 -> 10 9012 -> 12 */
// добавила количество попыток неправильного ввода
// 

string? numberStr = string.Empty;
int numberInt = 0;
int count = 0;
int maxCount = 3; //установить число попыток ввода - максимальное число попыток от нуля 0, 1, 2 => 3
bool check = false;
do // проверка на корректность ввода (искл символы) - три попытки
{
    Console.Write("Введите число: ");
    numberStr = Console.ReadLine();
    check = int.TryParse(numberStr, out numberInt);
    if (!check)
    {
        if (count == maxCount - 1)
        {
            Console.WriteLine("Три попытки ввода числа не соответствующего параметрам задачи, запустите программу заново.");
            count++;
        }
        else
        {
            Console.WriteLine("Число не соответствует параметрам, попробуйте еще раз");
            count++;
        }
    }
    else
    {
        count = maxCount + 1;
    }
}
while (count < maxCount);
int sum = 0; //вариант с int amount = numberStr.Length; - не подойдет если число отрицательное
int amount = 1;
int newNum = Math.Abs(numberInt);
if (count > maxCount)
{
    while (newNum > 9) // количество цифр в числе
    {
        newNum = newNum / 10;
        amount++;
    }
    int i = 1;
    int remainder = 0;
    newNum = Math.Abs(numberInt);
    Console.Write($"Сумма цифр числа {numberInt} представляет собой сумму следующих цифр:");
    for (i = 1; i <= amount; i++)
    {
        remainder = newNum % 10;
        sum = sum + remainder;
        newNum = newNum / 10;
        if (i == amount)
        {
            Console.WriteLine($" {remainder}.");
        }
        else
        {
            Console.Write($" {remainder},");
        }
    }
    Console.Write($"Сумма цифр числа {numberInt} равна {sum}.");
}