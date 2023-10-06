// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
        else Console.WriteLine($"{arr[i]}");
    }
    Console.Write("]");
}

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i]= arr[arr.Length-1-i]; // присваиваем первому элементу массива - последний элемент массива который находится как длинна - 1 и чтобы смещаться к центру вычитаем еще i который увеличивается
        arr[arr.Length-1-i]=temp; // последнему элементу кидаем значение из темпа который равен первому 
        
    }
}


int[] array = CreateArrayRndInt(12, -9, 9);

PrintArray(array);
ReverseArray(array);
Console.Write(" ");
PrintArray(array);
