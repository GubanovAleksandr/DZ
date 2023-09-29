// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


static int Exponent(int a, int b)
    {
        int res = 1;
        for (int i = 0; i < b; i++)
        {
            res *= a;
        }
        return res;
    }
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B:");
int b = Convert.ToInt32(Console.ReadLine());
    
int result = Exponent(a, b);
    Console.WriteLine($"Результат: {result}");
  