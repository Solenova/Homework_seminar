// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите  число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{n} ->");
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        int cub = i * i * i;
        Console.Write($",{cub}");
    }
}
else
{
    for (int i = 1; i <= Math.Abs(n); i++)
    {
        int cub = i * i * i;
        Console.Write($",{-cub}");
    }
}