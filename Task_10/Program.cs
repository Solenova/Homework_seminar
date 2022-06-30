// Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру
//этого числа

Console.Write("Введите трехзначное число ");
string a = Console.ReadLine();
int b = a.Length;
if (b == 3)
{
    int c = Convert.ToInt32(a);
    c = c % 100/10;
        Console.Write("Вторая цифра числа " + c);
}
else Console.Write("Это было не трехзначное число!");

