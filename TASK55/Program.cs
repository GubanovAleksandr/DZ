// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //функция заполнения массива случайными числами
                                                                   //                        0   1 
{
    int[,] matrix = new int[rows, columns]; //длинна массива для примера rows=3, columns=4
    Random rnd = new Random(); //заполняем массивв
    for (int i = 0; i < matrix.GetLength(0); i++) // i<rows  заполняем массив случайными числами от мин до макс
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix; // обязательно возвращаем результат массива
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");// 5-ка нужна для форматирования столбцов
        }
        Console.WriteLine("  |");// нужна для первода строки
    }

}

void ReplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
           int temp = matrix[i,j];
        matrix[i,j]=matrix[j,i];
        matrix[j,i]=temp; 
        }
        
    }
}
void ReplaceRowsColumnsLow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < i; j++)
        {
           int temp = matrix[i,j];
        matrix[i,j]=matrix[j,i];
        matrix[j,i]=temp; 
        }
        
    }
}




// тело программмы
int[,] array2d = CreateMatrixRndInt(4, 4, -100, 10);// передаем параметры в функцию для заполнения матрицы и присваиваем в переменнуй аррай2д
PrintMatrix(array2d); //выводим матрицу аррай 2д в консоль  с помощью метода
Console.WriteLine();
ReplaceRowsColumns(array2d);
PrintMatrix(array2d);

Console.WriteLine();
ReplaceRowsColumnsLow(array2d);
PrintMatrix(array2d);