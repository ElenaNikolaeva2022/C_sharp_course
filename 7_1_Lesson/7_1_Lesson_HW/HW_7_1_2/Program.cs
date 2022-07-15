// 2. Напишите программу, которая на вход принимает позиции элемента 
//    в двумерном массиве, и возвращает значение этого элемента или же 
//    указание, что такого элемента нет.
//    Например, задан массив: 
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    1 7 -> такого числа в массиве нет

int[,] DoubleArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
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
        for (int j = 0; j < rows; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = DoubleArray(4, 4, 0, 10);
PrintDoubleArray(array);

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());

if (row < 1 || column < 1 || row > array.GetLength(0) || column > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет ");
}

else
{
    Console.WriteLine($"На позиции {row}; {column} находится {array[row - 1, column - 1]} ");
}

