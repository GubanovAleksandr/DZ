﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


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
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); // выдаем если последний элемент массива то соскобками иначе без
        else Console.Write($"{arr[i]}");
    }
    //Console.Write("]");
}
int [] GetSumPositiveNegativeElem(int []arr) // передаем исходный массив в метод
{
    int sumPositive =0;
    int sumNegative =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >0 ) sumPositive += arr[i];
        else sumNegative +=arr[i];
    }
return new int[] {sumPositive, sumNegative};

}

int[] array = CreateArrayRndInt(12, -9, 9);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int[] sumPositiveNegativeElem =GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов - > {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов - > {sumPositiveNegativeElem[1]}");


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     //Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     //Console.Write("]");
// }

// int[] GetSumPositiveNegativElem(int[] arr)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) sumPositive += arr[i];
//         else sumNegative += arr[i];
//     }

//     return new int[] {sumPositive, sumNegative};
// }

// int GetSumPositiveElem(int[] arr)
// {
//     int sum = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) sum += arr[i];
//     }

//     return sum;
// }

// int GetSumNegativeElem(int[] arr)
// {
//     int sum = 0;
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < 0) sum += arr[i];
//     }

//     return sum;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);

// Console.Write("[");
// PrintArray(array);
// Console.WriteLine("]");

// int[] sumPositiveNegativElem = GetSumPositiveNegativElem(array);
// Console.WriteLine($"Сумма положительных элементов -> {sumPositiveNegativElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов -> {sumPositiveNegativElem[1]}");

// int sumPositiveElem = GetSumPositiveElem(array);
// int sumNegativeElem = GetSumNegativeElem(array);
// Console.WriteLine($"Сумма положительных элементов -> {sumPositiveElem}");
// Console.WriteLine($"Сумма отрицательных элементов -> {sumNegativeElem}");