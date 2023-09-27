int number = new Random().Next(100, 1000);
//Console.WriteLine($"{number}- > {numResult}");

int deliteSecondDigit = DeliteSecondDigit(number);
Console.WriteLine($"{number}- > {deliteSecondDigit}");

int DeliteSecondDigit(int num)
{
    int firstDigit = num /100;
    int lastDigit = num % 10;
    int numResult = firstDigit*10+lastDigit;
    return numResult;
}