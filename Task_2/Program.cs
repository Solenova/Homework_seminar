//Напишите программу, которая на вход 
//принимает два числа и выдаёт, какое число большее, а какое меньшее.int
Console.Write("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max=" + a);
}
else
    if (a != b)
{
    Console.WriteLine("max=" + b);
}
else Console.WriteLine("Числа равны");
