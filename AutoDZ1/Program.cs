//Вид 1 ничего не принимает ничего не возвращает

void Metod1()
{
    Console.WriteLine("Автор :");
}
Metod1(); // так вызывается этот метод

//Вид 2 которые ничего не возвращают но могут принимать аргументы
void Metod2(string msg)
{
    Console.WriteLine(msg);
}

Metod2("Текст сообщения");

void Metod21(string msg, int count){
    int i=0;
    while( i< count)
    {
        Console.WriteLine(msg);
        i++;

    }
}
Metod21(msg: "текст",4);
Metod21(count: 4, msg: "новый текст");

//Вид 3 что то возвращают но ничег не принимают

int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);
//Вид 4  чтотто принимают и чтото возвращают

// string Metod4(int count, string c)
// {
//     int i=0;
//     string result= "";
//     while( i<count)
//     {
//         result +c;
//         i++;
//     }
//     return result;
// }
// string res= Metod4(10,"asdfg");
// Console.WriteLine(res);


for(int i=2; i<10; i++)
{
    for(int j=2;j<=10; j++)
    {
        Console.WriteLine($"{i}x{j} = {i*j}");
    }
    Console.WriteLine();
}