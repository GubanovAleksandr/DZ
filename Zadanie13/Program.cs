// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//345687 /10 =34568 /10 =3456 /10 =345 %10 =8

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

while (num >999) num /=10;
Console.WriteLine(num %10);

int res  = GetThirdDigit(num);
Console.WriteLine(res);

int GetThirdDigit(int number)
{
    while (num>999) num /=10;
    return num%10;
}
