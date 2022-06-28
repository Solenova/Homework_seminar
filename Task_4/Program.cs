//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.Write("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("max=" + a);
    }
    else Console.WriteLine("max=" + c);
}
else
    if (b > c)
{
    Console.WriteLine("max=" + b);
}
else Console.WriteLine("max=" + c);