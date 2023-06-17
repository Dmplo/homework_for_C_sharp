// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
    System.Console.Write($"{message} ");
    return int.Parse(Console.ReadLine());
}
System.Console.WriteLine("Введите кординаты точки А:");
int x1 = Prompt("x:");
int y1 = Prompt("y:");
int z1 = Prompt("z:");

System.Console.WriteLine("Введите кординаты точки B:");
int x2 = Prompt("x:");
int y2 = Prompt("y:");
int z2 = Prompt("z:");

double distanceX = x2 - x1;
double distanceY = y2 - y1;
double distanceZ = z2 - z1;


double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
System.Console.WriteLine($"Расстояние между точками A и B составляет {distance:f2}");


