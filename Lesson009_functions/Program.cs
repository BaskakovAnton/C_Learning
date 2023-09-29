using System.Threading;
// // вид 1

// void Method1()
// {
//     System.Console.WriteLine("Автор ...");
// }

// Method1(); //вызов метода

// //вид 2
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }

// Method2(msg: "Текст сообщения")

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(msg: "Текст", count: 4);


//вид3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// System.Console.WriteLine(year);


//вид4
string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(count: 10, text: "a");
Console.WriteLine(res);