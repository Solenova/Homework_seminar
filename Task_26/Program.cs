// Задача 26: напишите программу, которая принимает на вход число 
//и выдает количество цифр в числе.



Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (num > 0)
{
    i++;
    num /= 10;
}
Console.WriteLine("Количество цифр введенного числа : {0}", i);
 
//2 решение
// Console.WriteLine("Введите число: ");
//             int a = int.Parse(Console.ReadLine());

//             int count = 0;

//             while (a != 0)
//             {
//                 a = a / 10;
//                 count++;
//             }
//             Console.WriteLine(count);


