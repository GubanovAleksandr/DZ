// программа выдает номре четверти

int Quater(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.WriteLine("X:");
int xCoordinate  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int yCoordinate  = Convert.ToInt32(Console.ReadLine());

int quater= Quater(xCoordinate, yCoordinate);

string result = quater >0
                ? $"Указананные координаты соответвуют четверти {quater}"
                : "Введены некорректные координаты";

Console.WriteLine(result);