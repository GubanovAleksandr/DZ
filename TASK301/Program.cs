string GetCoordinatosRange(int num)
{
    if (num == 1) return "x>0, y>0";
    if (num == 2) return "x < 0,  y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти по ХУ");
int quater  = Convert.ToInt32(Console.ReadLine());


string getCoordinatosRange = GetCoordinatosRange(quater);

string result = getCoordinatosRange != null ? $"Указаннойчетверти соответвует диапозон координат {getCoordinatosRange}"
                : "Введены некорректные данные";

Console.WriteLine(result);