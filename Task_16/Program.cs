// напишите пргорамму, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
var rnd1 = new Random();

var a = rnd1.Next(1, 100);
var b = rnd1.Next(1, 100);
Console.WriteLine(a);
Console.WriteLine(b);
if(a*a==b||b*b==a) Console.WriteLine($"{a},{b} -> да");
else Console.WriteLine($"{a},{b} -> нет");
//string  result = a % b != 0 ? $"{rndNum1} не кратно {rndNum2}, остаток {rndNum1 % rndNum2}" : $"{rndNum1} кратно {rndNum2} ";
//Console.WriteLine(result);