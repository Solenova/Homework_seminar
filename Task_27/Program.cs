//  Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

int SumNam (int nam)
{
    nam=Math.Abs(nam);
    int sum=0;
    while (nam!=0)
    {
        int namost=nam%10;
        nam=nam/10;
        sum+=namost;
    }
    return sum;
}
int s=SumNam(a);
Console.Write($"Сумма цифр числа {a} равна {s}");