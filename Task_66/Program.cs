// Задача 66: Задайте значения М и N. Напишите программу, которая найдет 
//сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Задайте начальное число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте конечное число ");
int numEnd = Convert.ToInt32(Console.ReadLine());

int summ = SummNumber(num, numEnd);
Console.WriteLine($"Сумма чисел от {num} до {numEnd} равна {summ}");

int SummNumber(int n, int m)
{
    if (n < m) return SummNumber(n + 1, m) + n;
    else if (n > m) return SummNumber(n - 1, m) + n;
    return n;
}