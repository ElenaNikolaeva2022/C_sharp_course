// Задача 1: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее. 
// a = 5; b = 7 -> max = 7 
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3 

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;

Console.Write("max = ");
Console.WriteLine(max);