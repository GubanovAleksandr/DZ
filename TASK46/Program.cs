//Задайте двухмерный М,Н массив заполненый случайными числами




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
//для того что бы проходить не постолбцам а по строкам меняем в циклах гетленс 0-1 и j,i строку matrix[i,j]не трогаем



void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
    
}
int[,] array2d =CreateMatrixRndInt(3,4, -100, 100);// передаем параметры в функцию для заполнения матрицы и присваиваем в переменнуй аррай2д
PrintMatrix(array2d); //выводим матрицу аррай 2д в консоль  с помощью метода
