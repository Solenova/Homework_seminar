// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите натуральное пятизначное число: ");
string a = Console.ReadLine();
int count = 0;
int del = 10000;
int b= Convert.ToInt32(a);
if (b > 9999 && b < 100000)
{
    for (int i = 1; i < 3; i++)
    {
        int azel = b / del;
        int aost = b % 10;
        b = b % del / 10;
        if (azel == aost) count ++;
        del = del / 100;
    }
    if (count == 2) Console.WriteLine($"{a} палиндром");
    else Console.WriteLine($"{a} не палиндром");

}
else Console.Write("Вы ввели не то число.");