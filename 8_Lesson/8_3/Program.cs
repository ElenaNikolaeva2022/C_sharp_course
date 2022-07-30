// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9

//         Набор данных            |     Частотный массив
//   { 1, 9, 9, 0, 2, 8, 0, 9 }    |   0 встречается 2 раза
//                                 |   1 встречается 1 раз
//                                 |   2 встречается 1 раз
//                                 |   8 встречается 1 раз
//                                 |   9 встречается 3 раза
// ----------------------------------------------------------
//    1, 2, 3                      |   1 встречается 3 раза
//    4, 6, 1                      |   2 встречается 2 раз
//    2, 1, 6                      |   3 встречается 1 раз
//                                 |   4 встречается 1 раз
//                                 |   6 встречается 2 раза

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
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

int[] FrequencyDict(int[,] arr)
{
    int[] freq = new int[10];

    foreach (int item in arr) freq[item] += 1;
    return freq;
}

void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} meets: {arr[i]}");
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 10);
Print(arr_1);

int[] mass = FrequencyDict(arr_1);
PrintMass(mass);
