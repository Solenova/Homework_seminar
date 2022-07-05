// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
int del = 10000;

if (a > 9999 && a < 100000)
{
    for (int i = 1; i < 3; i++)
    {
        int azel = a / del;
        int aost = a % 10;
        a = a % del / 10;
        if (azel == aost) count ++;
        del = del / 100;
    }
    if (count == 2) Console.WriteLine("палиндром");
    else Console.WriteLine("непалиндром");

}
else Console.Write("Вы ввели не пятизначное число.");