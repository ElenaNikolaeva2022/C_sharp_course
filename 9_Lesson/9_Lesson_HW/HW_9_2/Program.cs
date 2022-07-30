// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму 
//      натуральных элементов в промежутке от M до N с помощью рекурсии. 
//      M = 1; N = 15 -> 120 
//      M = 4; N = 8 -> 30 

int SumElements(int M, int N)
{
    if (N < M) return 0;
    else return N + SumElements(M, N - 1);
}

Console.WriteLine(SumElements(1, 15));
Console.WriteLine(SumElements(4, 8));