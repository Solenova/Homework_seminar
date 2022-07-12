// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

void LinUr ()
{
Console.WriteLine("Задайте данные для линейных уравнений y=k1*x+b1, y=k2*x+b2  и Вы, узнаете координаты точки пересечения прямых.");
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());

if (k1!=k2)
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    Console.WriteLine($"Координаты точки пересечения прямых ({x:N2};{y:N2})");
}
else Console.WriteLine($"Точек пересечения нет");
}
LinUr ();