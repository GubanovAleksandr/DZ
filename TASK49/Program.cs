/*Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.*/

//функции
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

void ReplaceEvenIndexesNumberToSqare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // i<rows  заполняем массив случайными числами от мин до макс
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            if (i % 2 == 0 && j % 2 == 0) 
            {
                matrix[i,j] *= matrix[i,j];
            };
        }
    }
   }

// тело программмы
int[,] array2d = CreateMatrixRndInt(5, 5, 0, 10);// передаем параметры в функцию для заполнения матрицы и присваиваем в переменнуй аррай2д
PrintMatrix(array2d); //выводим матрицу аррай 2д в консоль  с помощью метода
Console.WriteLine(" --------------------");
ReplaceEvenIndexesNumberToSqare(array2d);
PrintMatrix(array2d);