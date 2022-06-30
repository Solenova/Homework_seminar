// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write("Введите число ");
string a = Console.ReadLine();         
int b = a.Length;                       
if (b >= 3)
{
    double c = Convert.ToDouble(a);
    c = c / Math.Pow(10, (b - 3)) % 10;
    int d = Convert.ToInt32(c);
    Console.Write("Третья цифра числа " + d);
}
else Console.Write("Третьей цифры нет!");