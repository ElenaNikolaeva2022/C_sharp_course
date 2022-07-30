// 1. Задайте значения M и N. Напишите программу, которая выведет все чётные
//    натуральные числа в промежутке от M до N с помощью рекурсии. 
//    M = 1; N = 5 -> "2, 4" 
//    M = 4; N = 8 -> "4, 6, 8" 

string Numbers(int M, int N)
{
    if (M % 2 == 1) M = M + 1;

    if (M <= N)
    {
        if (N - M >= 2) return $"{M}, " + Numbers(M + 2, N);
        else return M.ToString();
    }
    else return String.Empty;
}

Console.WriteLine(Numbers(1, 5));
Console.WriteLine(Numbers(4, 8));
string s = Numbers(1, 4);
Console.WriteLine(s.Substring(0, s.Length - 4));

