Console.WriteLine("Введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100 && number <= 999)
{
    int lastDiget = number % 10;
    Console.WriteLine($"последняя цифра числа: {lastDiget}");
}
else
    Console.WriteLine("Неверное число");