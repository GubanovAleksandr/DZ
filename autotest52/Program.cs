// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".
// Аргументы, передаваемые в метод/функцию:
// '18, 76, 11'
// На выходе:
// 18      76      11  
// Сумма нечетных элементов: 76

// using System;

// class Program
// {
//     static int SumOddElements(int[] array)
//     {
//         int sum_odd = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (i % 2 != 0)
//             {
//                 sum_odd += array[i];
//             }
//         }
//         return sum_odd;
//     }

//     static void PrintArray(int[] array)
//     {
//         Console.WriteLine(string.Join("\t", array));
//     }

//     static void Main(string[] args)
//     {
//         // Пример использования программы

//         // Создаем массив целых чисел
//         int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//         // Выводим элементы массива на экран
//         PrintArray(myArray);

//         // Находим сумму элементов с нечетными индексами
//         int sumOddElements = SumOddElements(myArray);

//         // Выводим результат на экран
//         Console.WriteLine("Сумма элементов с нечетными индексами: " + sumOddElements);
//     }
// }
using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
// Введите свое решение ниже
int sum_odd = 0;
        for (int i = 0; i < array.Length; i++)
         {
             if (i % 2 != 0)
             {
                 sum_odd += array[i];
             }
         }
         return sum_odd;

    }

    public static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
for (int i=0; i< array.Length; i++)
{
  if(i < array.Length -1) Console.Write($"{array[i]}\t");
 else Console.WriteLine($"{array[i]}\t");
}

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] {18, 76, 11};
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}

