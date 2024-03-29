﻿// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии. 
//       A = 3; B = 5 -> 243 (3 в пятой степени)
//       A = 2; B = 3 -> 8

int Power (int A, int B)
{
    if (B == 0) return 1;
    return Power (A, B - 1) * A;
}

Console.Write(Power(3, 5));