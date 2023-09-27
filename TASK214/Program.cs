


bool Multiple0fTwoNumbers(int num)
{
    bool multipal = (num % 7 == 0) && (num % 23 == 0);
    return multipal;

}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiple0fTwoNumbers(number);
Console.WriteLine(result ? "да" : "нет");
