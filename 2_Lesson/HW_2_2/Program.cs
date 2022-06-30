// Задача 2: Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого
// числа. (456 -> 46), (782 -> 72), (918 -> 98)


void NumRendom()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num} -> {num / 100}{num % 10}");
}

NumRendom();

// --------------------------------------------------------------- 2 вариант

// void NumRendom()
// {
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine($"{num} -> {num / 100 * 10 + num % 10}");
// }
// NumRendom();
