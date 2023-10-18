// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

//методы

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

int SumElemMainDiaganl(int[,]matrix)
{
    int sum=0;
     for (int i = 0; i < matrix.GetLength(0); i++) // i<rows  заполняем массив случайными числами от мин до макс
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            if (i==j)
            {
                sum += matrix[i,j];
            };
        }
    }
    return sum;
}

// тело программмы
int[,] array2d = CreateMatrixRndInt(5, 5, 0, 10);// передаем параметры в функцию для заполнения матрицы и присваиваем в переменнуй аррай2д
PrintMatrix(array2d); //выводим матрицу аррай 2д в консоль  с помощью метода
int res = SumElemMainDiaganl(array2d);

Console.WriteLine($"Сумма элементов по главной диаганали: {res}");
