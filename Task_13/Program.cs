// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int amod = Math.Abs(a);
int b = Convert.ToString(amod).Length;
//int b = Convert.ToInt32(a);
if (b > 2)
{
double c = Convert.ToDouble(amod);
c = c / Math.Pow(10, (b - 3)) % 10;
Console.Write(c);
int d = Convert.ToInt32(c);
Console.Write("Третья цифра числа " + d);
}
else Console.Write("Третьей цифры нет!");