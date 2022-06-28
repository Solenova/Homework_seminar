// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int c = 1;
while (c <= a)
{
    int d=c%2;
    if (d == 0)
    {
        Console.Write(" " + c);
    }
c +=1;
}