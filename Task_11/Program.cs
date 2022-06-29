// Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру
//этого числа.
int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"{rndNum} => ");
int a = rndNum / 100;
int ost1 = rndNum % 100;
int b = ost1 / 10;
int c = rndNum % 10;
int result = a * 10 + c;
Console.WriteLine($"{result}");
