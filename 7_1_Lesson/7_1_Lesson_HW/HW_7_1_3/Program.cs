// 3. Задайте двумерный массив из целых чисел. 
//    Найдите среднее арифметическое элементов в каждом столбце.
//    Например, задан массив: 
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// int[,] DoubleArray(int row, int column, int from, int to)
// {
//     int[,] array = new int[row, column];

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(from, to);
//         }
//     }
//     return array;
// }

// void PrintDoubleArray(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($" {array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[] MeanArithmetic(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     double[] avg = new double[columns];

//     for (int j = 0; j < columns; j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < rows; i++)
//         {
//             sum += array[i, j];
//         }
//         avg[j] = Math.Round((double)sum / rows, 1);
//     }
//     return avg;
// }

// void PrintArray(double[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < length - 1) Console.Write("; ");
//         else Console.WriteLine();
//     }
// }

// int[,] array = DoubleArray(3, 4, 1, 10);
// PrintDoubleArray(array);
// PrintArray(MeanArithmetic(array));


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ArithmeticMean(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for (int i = 0; i < column; i++)
    {
        res = 0;
        for (int j = 0; j < row; j++) res += arr[j, i];
        Console.Write($"{Math.Round(res / row, 2)}; ");
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 6);
Print(arr_1);

ArithmeticMean(arr_1);