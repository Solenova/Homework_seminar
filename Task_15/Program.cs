//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным.
Console.Write("Введите число ");
string a = Console.ReadLine();         
int b = Convert.ToInt32(a);                    
if (b>0 && b<8)
{
    if (b<6) 
    {
        Console.Write("Не выходной ");
    }
    else 
    {
        Console.Write("Выходной ");
    }    
}
else Console.Write("Такого дня недели нет!");