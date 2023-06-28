// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//https://www.interestprograms.ru/source-codes-tochka-peresecheniya-dvuh-pryamyh-na-ploskosti
// A1 = 5, C1 = 2, A2 = 9, C2 = 4 -> (-0,5; -0,5)
// A1 = 1, C1 = 4, A2 = 1, C2 = -7 -> Прямые параллельны друг другу
// A1 = 1, C1 = 0, A2 = -1, C2 = 0 -> Прямые перпендикулярны

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string CheckCrossLines(double a1, double a2, double c1, double c2)
{
    string str = String.Empty;
    double b1 = -1;
    double b2 = -1;

    if ((a1 * b2 - a2 * b1) == 0)
    {
        str = "Прямые параллельны друг другу. ";
        if (a1 * b2 == b1 * a2 && a1 * c2 == a2 * c1 && b1 * c2 == c1 * b2)
        {
            str += "Прямые совпадают и имеют бесконечное количество решений.";
        }
    }
    else if ((a1 * a2 + b1 * b2) == 0)
    {
        str = "Прямые перпендикулярны.";
    }
    else
    {
        double crossX = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
        double crossY = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);
        str = $"Точка пересечения двух прямых имеет координаты: ({crossX}, {crossY}).";
    }
    return str;
}

System.Console.WriteLine("Уравнение прямой записывается как: Ax+By+C");
double a1 = ReadInt("Введите значение A первой прямой: ");
double c1 = ReadInt("Введите значение С первой прямой: ");
double a2 = ReadInt("Введите значение A второй прямой: ");
double c2 = ReadInt("Введите значение С второй прямой: ");
System.Console.WriteLine(CheckCrossLines(a1, a2, c1, c2));