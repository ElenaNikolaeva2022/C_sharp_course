﻿// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNum(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(CountNum(456));
Console.WriteLine(CountNum(78));
Console.WriteLine(CountNum(89126));
