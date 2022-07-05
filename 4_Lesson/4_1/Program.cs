// Функции в программировании:
// Вид 3 - ничего не принимает, что-то возвращает.

// Демонстрация решени.
// Задача 1: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А. 
// 7 -> 28 
// 4 -> 10 
// 8 -> 36

// int SumNum(int num)
// {
//     int all_sum = 0;
//     for(int i = 1; i <= num; i++)
//     {
//         all_sum += i;
//     }
//     return all_sum;
// }

// Console.WriteLine(SumNum(7));
// Console.WriteLine(SumNum(4));
// Console.WriteLine(SumNum(8));

// Вариант без фигурных скобок, если в них только одно выражение.
// Но когда два выражения, то лучше с фигурными скобками.

int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i;

    return all_sum;
}

Console.WriteLine(SumNum(7));
Console.WriteLine(SumNum(4));
Console.WriteLine(SumNum(8));
