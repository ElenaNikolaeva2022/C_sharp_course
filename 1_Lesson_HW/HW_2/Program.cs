// Задача 2: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел. 
// 2, 3, 7 -> 7 
// 44 5 78 -> 78 
// 22 3 9 -> 22 

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("max = ");
Console.WriteLine(max);

// Решение Марии:
// int n_1 = int.Parse(Console.ReadLine());
// int n_2 = int.Parse(Console.ReadLine());
// int n_3 = int.Parse(Console.ReadLine());

// if (n_1 < n_2)
// {
//     n_1 = n_2;
// }
// if (n_1 < n_3)
// {
//     n_1 = n_3;
// }
// Console.WriteLine($"The number {n_1} is the largest");
