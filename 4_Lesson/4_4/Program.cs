﻿// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Наша функция ничего не возвращает, а просто выводит на экран,
// последовательно, элементы нашего массива.

void Arr()
{
    int[] array = new int[8];

    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}

Arr();