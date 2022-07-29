// 4. Задайте двумерный массив. Введите элемент, 
//    и найдите первое его вхождение,
//    выведите позиции по горизонтали и вертикали,
//    или напишите, что такого элемента нет.
//      1 4 7 2 
//      5 9 2 3
//      8 4 2 4 
//    Введенный элемент 2, результат: [1, 4]
//    Введенный элемент 6, результат: такого элемента нет.

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

void OccurrenceElement(int[,] arr, int num)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    string answer = "Нет";

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (arr[i, j] == num) answer = $"[{i + 1}, {j + 1}] ";

    Console.WriteLine($"Element {num} located in the matrix - {answer}");
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите номер для поиска: ");
int number = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);
OccurrenceElement(arr_1, number);