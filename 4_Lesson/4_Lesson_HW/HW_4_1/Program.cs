// 25. Напишите цикл, который принимает на вход два числа (A и B)
//     и возводит число A в натуральную степень B.
//     3, 5 -> 243 (3⁵)
//     2, 4 -> 16

// Решение:
// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());

// int step = a;
// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }

// Console.WriteLine("A в степени B равно: " + step);

//Решение:
int PowNum(int a, int b)
{
    int n_pow = a;

    for (int i = 1; i < b; i++)
    {
        n_pow *= a;
    }
    return n_pow;
}
Console.WriteLine(PowNum(3, 5));
Console.WriteLine(PowNum(2, 4));
