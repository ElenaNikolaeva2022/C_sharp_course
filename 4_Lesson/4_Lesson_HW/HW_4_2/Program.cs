// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Решение:
// int Num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (Num > 0)
// {
//     int num = Num % 10;
//     Num = Num / 10;
//     sum = sum + num;
// }

// Console.WriteLine(sum);

// Вариант1. Решение:
// int SumNums(int num)
// {
//     int n_sum = 0;
//     while (num > 0)
//     {
//         n_sum += num % 10;
//         num /= 10;
//     }
//     return n_sum;
// }
// Console.WriteLine(SumNums(452));
// Console.WriteLine(SumNums(82));
// Console.WriteLine(SumNums(9012));


// Вариант2. Решение:
int SumNums(int num)
{
    int n_sum = 0;

    for (int i = num; num != 0; num /= 10)
        n_sum += num % 10;

    return n_sum;
}
Console.WriteLine(SumNums(452));
Console.WriteLine(SumNums(82));
Console.WriteLine(SumNums(9012));
