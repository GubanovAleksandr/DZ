Console.WriteLine("Введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());

int lastDiget = number%10;
Console.WriteLine($"последняя цифра числа: {lastDiget}");
