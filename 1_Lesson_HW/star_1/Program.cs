// * Напишите программу вычисления модуля числа. 
//    2 -> 2 
//    -3 -> 3 
//    -7 -> 7

int N = int.Parse(Console.ReadLine());

if (N < 0 )
{
    N = -N;
}
Console.WriteLine(N);