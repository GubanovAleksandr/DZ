int[] array = { 1, 12, 13, 2, 3, 4, 555, 56, 77, };
int n = array.Length;
int find = 12;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
    Console.WriteLine(index);
    break;
    //index= index +1;
    }
}
Console.WriteLine(index);
