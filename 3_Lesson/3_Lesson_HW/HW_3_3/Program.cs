<<<<<<< HEAD
﻿// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
    Console.WriteLine();
}

Cube(3);
Cube(5);


// void Squares(int n)
// {
//     double[] nums = new double[n];
//     int index = 0;

//     Console.WriteLine($"{n} -> ");
//     while (index < n)
//     {
//         nums[index] = Math.Pow((index + 1), 3);
//         Console.WriteLine($"{nums[index]}, ");
//         index += 1;
//     }
//     Console.WriteLine();
// }

// Squares(6);
// Squares(2);
// Squares(11);


=======
﻿
>>>>>>> 4_lesson
