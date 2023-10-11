// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArrayInt(int size)
{
        int[]arr = new int[size];
        for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int Count(int[] arr)
{
     int sum =0;
        for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) sum++;
    }
   return sum;
}

Console.WriteLine("Введите из скольки элементов состоит массив");
int length= Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayInt(length);
Count(array);
Console.WriteLine($"чисел больше >0 = {Count(array)}");

