// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/* int x1 = Read("x1");
int y1 = Read("y1");
int z1 = Read("z1");
int x2 = Read("x2");
int y2 = Read("y2");
int z2 = Read("z2");
double D = Math.Sqrt(Math.Pow(x1 - y1 - z1, 2) + Math.Pow(x2 - y2 - z2, 2)); */


int Read(string coordinate)
{
    Console.WriteLine($"Введите координаты - {coordinate} :");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
double Distance()
{
    int x1 = Read("x1");
    int y1 = Read("y1");
    int z1 = Read("z1");
    int x2 = Read("x2");
    int y2 = Read("y2");
    int z2 = Read("z2");
    double D = Math.Sqrt(Math.Pow(x1 - y1 - z1, 2) + Math.Pow(x2 - y2 - z2, 2));
    return D;
}
void Answer()
{
    double Dis = Distance();
    Console.WriteLine($"Distante ={Dis}");
}
Answer();