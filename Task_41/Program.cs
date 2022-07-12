// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Укажите сколько чисел Вы будете вводить ");
int quantity = int.Parse(Console.ReadLine());

void QuantityPositiv (int nam)
{
    int count=0;
    for (int i=0; i<nam; i++)
    {
        Console.Write($"{i+1} число:");
        int temp=int.Parse(Console.ReadLine());
        //Console.WriteLine();
        if (temp>0) count+=1;
    }
    Console.WriteLine($"Введено {count} положительных чисел ");
}
QuantityPositiv(quantity);
