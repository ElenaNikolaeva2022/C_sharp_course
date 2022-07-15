// 3. Задайте двумерный массив из целых чисел. 
//    Найдите среднее арифметическое элементов в каждом столбце.
//    Например, задан массив: 
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] DoubleArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

void PrintDoubleArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] MeanArithmetic(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] avg = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        avg[j] = Math.Round((double)sum / rows, 1);
    }
    return avg;
}

void PrintArray(double[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i < length - 1) Console.Write("; ");
        else Console.WriteLine();
    }
}

int[,] array = DoubleArray(3, 4, 1, 10);
PrintDoubleArray(array);
PrintArray(MeanArithmetic(array));
