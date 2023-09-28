// Напишите программу которая принимает на ввод число Н и выдает квадрат чисел от 1 до Н

void TableSquare(int num)
{
    int count =1;
    while (count <=num)
    {
Console.WriteLine($"{count,3}  {count*count,1}");
count++;
    }
}
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);