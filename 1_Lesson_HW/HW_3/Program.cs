﻿// Задача 3: Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка). 
// 4 -> да 
// -3 -> нет 
// 7 -> нет 

Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Да");
}
else

{
    Console.WriteLine("Нет");
}

// Решение Марии:
// int n_1 = int.Parse(Console.ReadLine());
// if (n_1 % 2 == 0)
// {
//     Console.Write($"The number {n_1} is even");
// }
// else
// {
//     Console.Write($"The number {n_1} is odd");
// }
