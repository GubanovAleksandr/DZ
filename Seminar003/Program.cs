Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2)
{
    Console.WriteLine($"{number1} является квадратом второго");
}
else
{
    Console.WriteLine($"{number2} не является квадратом первого числа ");
}