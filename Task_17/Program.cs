// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
Console.Clear();
Console.WriteLine("Введите координты точки");
Console.Write("X=");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y=");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("1 четверть");
// else if (x < 0 && y > 0) Console.WriteLine("2 четверть");
// else if (x < 0 && y < 0) Console.WriteLine("3 четверть");
// else if (x > 0 && y < 0) Console.WriteLine("4 четверть");
// else Console.WriteLine("Введены некорректные координаты");

// string Quarter(int xc, int yc)
// {
//     if (xс > 0 && yс > 0) return "1 четверть";
//     if (xс < 0 && yс > 0) return "2 четверть";
//     if (xс < 0 && yс < 0) return "3 четверть";
//     if (xс > 0 && yс < 0) return "4 четверть";
//     return "Введены некорректные координаты";

// }
// string result = Quarter (x,y);
// Console.WriteLine(result);


string Quarter(int x, int y)
{
    switch ((x, y))
    {
        case ( > 0, > 0): Console.WriteLine("1 четверть"); break;
        case ( < 0, > 0): Console.WriteLine("2 четверть"); break;
        case ( < 0, < 0): Console.WriteLine("3 четверть"); break;
        case ( > 0, < 0): Console.WriteLine("4 четверть"); break;
        default:Console.WriteLine("Введены некорректные данные"); break;
    }
}
string result = Quarter(x, y);

// switch ((x,y))
// {
//     case (>0,>0): Console.WriteLine ("1 четверть");
//     break;
//     case (<0,>0): Console.WriteLine ("2 четверть");
//     break;
//     case (<0,<0): Console.WriteLine ("3 четверть");
//     break;
//     case (>0,<0): Console.WriteLine ("4 четверть");
//     break;
//     default: Console.WriteLine ("Введены некорректные данные");

// }