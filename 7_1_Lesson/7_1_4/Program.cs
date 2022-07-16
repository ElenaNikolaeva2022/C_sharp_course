// 4. Задайте двумерный массив. Введите элемент, 
//    и найдите первое его вхождение,
//    выведите позиции по горизонтали и вертикали,
//    или напишите, что такого элемента нет.
//      1 4 7 2 
//      5 9 2 3
//      8 4 2 4 
//    Введенный элемент 2, результат: [1, 4]
//    Введенный элемент 6, результат: такого элемента нет.

// void PrintArray(int[,] matr )
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         matr[i, j] = new Random().Next(1, 10); // [1; 10) - скобки полуинтервала
//     }
//   }
// }

// void FindPosOfNum (int [,] array, int num)
// {
//     // bool flag = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[1, j] == num)
//             {
//                 Console.WriteLine($"[{i++}, {j++}]");
//                 return;
//             }
//         }
//     }
//     Console.WriteLine("Не найдено");
// }


// int[,] matrix = FillArray(4, 4);
// PrintArray(matrix);
// FindPosOfNum(matrix, 2);
