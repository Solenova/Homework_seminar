// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
//P.s.: может быть переполнение данных,можно использовать 
// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());
// //int mult = 1;

// int Proizved (int number)
// {
//     int mult = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         mult=mult*i;
//     }
// return mult;
// }

// if (num>0) 
// {
//     int result=Proizved(num);
// Console.WriteLine($"* чисел от 1 до {num}={result}");
// }
// else Console.WriteLine($"Надо ввести натуральное число");
// 2 сппособ
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int res = 1;
int start = 1;
while (start <= n)
{
    try 
    {
    checked
    {
    res *= start;
    start++;
    }
    }
    catch (Exception)
    {
        Console.WriteLine("Переполнение типа!");
        break;
    }
}
Console.WriteLine($"* чисел от 1 до {start-1}={res}");