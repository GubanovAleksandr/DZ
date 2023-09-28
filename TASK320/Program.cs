// Math.Pow(5,6);
// Math.Sqrt(5);
 double d= 5.098659;
// double dRound = Math.Round(d,2, MidpointRounding.ToZero);

// Console.WriteLine(dRound);
//Программа принимает координаты двух точек и находит растояние между ними

double FindDistance(int ax, int ay, int bx, int by)
{
    int catet1 = ax-bx;
    int catet2 = ay-by;
    double distance =Math.Sqrt((catet1*catet1) + (catet2*catet2));
    return distance;
}
Console.WriteLine("Введите координаты для точки А");
Console.WriteLine("X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.WriteLine("X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(x1, y1, x2, y2);
double resultRound = Math.Round(result,2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);

//округление черз интерполяцию

Console.WriteLine($"{d:F2}");
