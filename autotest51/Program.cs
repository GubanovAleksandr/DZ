// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t". 


public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
      int count=0;
    for (int i=0; i<array.Length; i++)
      {
        if (array[i] %2 == 0) count ++;
      }
      return count;
    }

    public static void PrintArray(int[] array)
    {
    // Введите свое решение ниже
for (int i=0; i< array.Length; i++)
{
  if(i < array.Length -1) Console.Write($"{array[i]}\t");
 else Console.WriteLine($"{array[i]}\t");
}

    }
// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 124, 378, 593, 821, 456 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}