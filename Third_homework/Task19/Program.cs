/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет.12821 -> да, 23432 -> да */

// Метод определения палиндрома
string GetPalindrome(int x)
{
    string palindrome = "No, it is not palindrome";
    if ((Math.Abs(x) / 10000) == (Math.Abs(x) % 10) && (Math.Abs(x) / 1000 % 10) == (Math.Abs(x) / 10 % 10))
    {
        palindrome = "Yes, it is palindrome";
    }
    return palindrome;
}

Console.Write("Введите пятизначное число = ");
int x = Convert.ToInt32(Console.ReadLine());
if ((Math.Abs(x) > 99999) || (Math.Abs(x) < 10000))
{
    Console.WriteLine("Число не соответствует условиям, попробуйте еще раз");
}
else
{
    string answer = GetPalindrome(x);
    Console.WriteLine(answer);
}