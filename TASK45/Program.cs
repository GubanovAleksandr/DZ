// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.


using System.Diagnostics.Contracts;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size]; //длинна массива
    Random rnd = new Random(); //заполняем массивв
    for (int i = 0; i < size; i++) // заполняем массив случайными числами от мин до макс
    {
        arr[i] = rnd.Next(min, max + 1);

    }
    return arr;
}

void PrintArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); // выдаем если последний элемент массива то соскобками иначе без
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int [] CopyArray(int [] arr)
{
int[] copy = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copy[i] = arr[i];
    }
    return copy;
}


int[] array = CreateArrayRndInt(8, 1, 11);
PrintArray(array);
int [] second = CopyArray(array);
PrintArray(second);
