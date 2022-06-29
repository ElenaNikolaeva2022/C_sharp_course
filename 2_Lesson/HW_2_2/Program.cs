// Задача 2: Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого
// числа. (456 -> 46), (782 -> 72), (918 -> 98)


void OneOfNum(int num_1, int num_3)
{
    if (num_1 % num_3 == 0)
    {
        Console.WriteLine($"{num_1}, {num_3}");
    }
    else
    {
        Console.WriteLine($"{num_1}, {num_3}");
    }
}
OneOfNum(456, 46);
OneOfNum(782, 72);
OneOfNum(918, 98);
