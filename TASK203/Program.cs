Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Remainder(int firstPar, int secondPar)
{
    return firstPar % secondPar;
}
int remainder = Remainder(firstNumber, secondNumber);
if (remainder == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"не Кратно, остаток{remainder}");