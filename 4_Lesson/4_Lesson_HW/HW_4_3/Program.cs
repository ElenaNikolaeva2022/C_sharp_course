// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Решение:
int[] arr1 = { 1, 2, 5, 7, 19 };
int[] arr2 = { 6, 1, 33 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr1);
PrintArray(arr2);


// Решение1:
// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] EightMass()
// {
//     int size = 8;

//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// int[] arr_1 = EightMass();
// Print(arr_1);
// int[] arr_2 = EightMass();
// Print(arr_2);