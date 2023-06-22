// Методы. Возвращаемые и не возвращаемые

// Не принимают и не возвращают

void Metod1()
{
    Console.WriteLine("Автор...");
}
Metod1();

// Принимает, но не возвращает

void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2("Текст сообщения...");

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Metod21("Текст...", 4);         
Metod21(count: 4, msg: "новый Текст...");            // именованые аргументы


// Возвращает, но не принимает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Принимает и возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;   // = "";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);



// Принимает и возвращает

string Method4_1(int count, string text)
{

    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string ress = Method4_1(10, "qwerty, ");
Console.WriteLine(ress);