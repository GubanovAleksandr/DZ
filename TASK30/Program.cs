// int[] array = new int[8];

// int[] array1 = new int[8]{4,48,8,8,8,8,8,8};
// int[] array2 = new int[]{4,48,8,8,8,8,8,8};
// int[] array3 = {4,48,8,8,8,8,8,8};
// var array4 =new int[8]{4,48,8,8,8,8,8,8};

// var n= 5/3+7/11+45;


// array[0] = 456;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.Write(array[i+ " "]);

// // }
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int [] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]= rnd.Next(2);
    }
    return array;
    }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

int[] arr =CreateArray(8);

PrintArray(arr);