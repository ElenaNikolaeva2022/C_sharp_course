﻿// 3. Задайте двумерный массив. 
//    Найдите сумму элементов главной диагонали. 
//    Например, задан массив:
//    1 4 7 
//    5 9 2 
//    8 4 2
//    Сумма элементов главной диагонали: 1+9+2 = 12 

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int SumElDiag(int[,] Array)
{
    int rows = Array.GetLength(0);
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += Array[i, i];
    }
    return sum;
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 101);
Print(arr_1);

Console.WriteLine(SumElDiag(arr_1));