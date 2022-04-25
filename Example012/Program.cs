// Вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();


//Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        i++;
        Console.WriteLine(msg);
    }
}
Method21(count: 4, msg: "Новый Текст");


//Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


//Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        i++;
        result = result + c;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);