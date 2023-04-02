// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Digit(Read());
int Read()

{
    Console.WriteLine("Введите число");
    int N = int.Parse(Console.ReadLine()!);
    return N;
}
void Digit(int num)
{
    int a = 1;
    while (a <= num)
    {
        double b = Math.Pow(a, 3); Console.Write(b + " "); a++;
    }
}