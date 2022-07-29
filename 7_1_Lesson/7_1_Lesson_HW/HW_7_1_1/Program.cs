// 1. Задайте двумерный массив размером m×n, 
//    заполненный случайными вещественными числами.
//       Пример:
//       m = 3, n = 4.
//       0,5    7     -2    -0,2 
//       1     -3,3    8    -9,9 
//       8      7,8   -7,1   9

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < row_size; j++)
            Console.Write($" {arr[i, j],6} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < row; j++)
            arr[i, j] = Math.Round(n_new.NextDouble() * -10, 2);
    return arr;
}

double[,] arr_1 = MassNums(3, 4, -10, 8); // 0,5 7 -2 -0,2
Print(arr_1);

double[,] arr_2 = MassNums(5, 6, -6, 7);  // 1 -3,3 8 -9,9
Print(arr_2);


// double[,] a = new double[3, 4];
// Random random = new Random();
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         a[i, j] = random.NextDouble() * 20 - 10; 
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }
