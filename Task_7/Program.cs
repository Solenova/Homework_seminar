// Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
Console.Write("Введите трехзначное число ");
string a = Console.ReadLine();
int b = a.Length;
if (b == 3)
{
    int c = Convert.ToInt32(a);
    c = c % 10;
    Console.Write("Последняя цифра числа " + c);
}
else Console.Write("Это было не трехзначное число!");
