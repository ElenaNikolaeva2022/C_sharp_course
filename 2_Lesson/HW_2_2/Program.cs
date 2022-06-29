// Задача 2: Напишите программу, которая выводит случайное 
// трёхзначное число и удвляет вторую цифру этого
// числа. (456  - 46), (782 - 72), (918 - 98)


void OneOfNum(int num_1, int num_2)
{
    if (num_1 % num_2 == 0)
    {
        // multiple (множественный)
        Console.WriteLine($"{num_1}, {num_2} -> multiple");
    }
    else
    {
        // not multiple remainder (не множественный остаток)
        Console.WriteLine($"{num_1}, {num_2} -> not multiple, the remainder {num_1 % num_2}");
    }
}
OneOfNum(34, 5);
OneOfNum(16, 4);