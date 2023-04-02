// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
void Palindrom(int number)
{
    if (number >= 10000)
    {
        int a = number / 10000; int b = number % 10;
        if (a == b)
        {
            number = number / 10; int c = (number / 100) % 10; int d = number % 10;
            if (c == d) Console.WriteLine("Полиндром");
        }
        else Console.WriteLine("Не полиндром");
    }
    else Console.WriteLine("Некорректное число!");
}
Palindrom(number);
