//программа которая выводит случайное число от 10 до 99 
//и показывает большую цифру в нем

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка от 10, 99 ->{number}");
//int firstDigit = number / 10;  //78/10 =7.8 - > так как инт то получается "7"
//int secondDigit = number % 10;

//if (firstDiget > secondDigit Digit) Console.WriteLine($"Наибольшая цифра числа {FirstDiget}");
//else Console.WriteLine($"Наибольшеая цифра числа ->"{ secondDigit});
//тернарный оператор
//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Наибольшеая цифра числа ->"{ maxDigit});


//заменяем программу методом 
int maxDigit = MaxDigit(number);
Console.WriteLine(maxDigit);

int MaxDigit(int num)
{
    int firstDiget = num / 10 ;
    int secondDigit = num % 10;
    return firstDiget > secondDigit ? firstDiget : secondDigit;

}
//