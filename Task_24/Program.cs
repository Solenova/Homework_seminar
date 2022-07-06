//напишите программу, ктороая принимает на вход число А и выдает сумму числе от 1 до А...
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int sum = 0;
// for (int i = 1; i <= num; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {num}={sum}");

// Решение с помощью метода:
int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
return sum;
}
int result=Sum(num);
Console.WriteLine($"Сумма чисел от 1 до {num}={result}");
