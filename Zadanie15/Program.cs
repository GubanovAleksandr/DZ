// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
int week = Convert.ToInt32(Console.ReadLine());

bool Weekend(int weekDay)
{
    if (weekDay>5)
    {
        return true;
    }
    return false;
}
bool WeekDay( int number)
{
    if (number >0 && number <7)
    {
        return true;
    }
    Console.WriteLine("Введено неверное число");
    return false;

}
if (WeekDay(week))
{
    if (Weekend(week))
    {
        Console.WriteLine("Это выходной день");
    }
    else {Console.WriteLine("Это рабочий день");    }
}