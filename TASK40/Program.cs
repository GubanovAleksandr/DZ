// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите первое число");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int side3 = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
    }
bool result = IsExistTriangle(side1, side2, side3);

Console.WriteLine(result? "Треугольник существует":"Треугольник не существует");
