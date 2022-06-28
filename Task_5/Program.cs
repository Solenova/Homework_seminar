// Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
Console.Write("Введите положительное число");
double a = Convert.ToInt32(Console.ReadLine());
double n = -a;
int c = (int)n;
if (a>0)
{
    while (c <= a)
    {
       Console.Write(" " + c);
      c += 1;
    }
}
else Console.Write("Error ");