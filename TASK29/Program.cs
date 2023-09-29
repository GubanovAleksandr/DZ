// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int [] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]= rnd.Next(100);
    }
    return array;
    }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ ", ");
    }
}

int[] arr =CreateArray(8);
Console.Write("[");
PrintArray(arr);
Console.WriteLine("]");