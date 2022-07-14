// 1: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//    сколько чисел > 0 ввёл пользователь.
//    0, 7, 8, -2, -2 -> 2
//    -1, -7, 567, 89, 223-> 3

// 1. ВАРИАНТ:
int NumM()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;
    }
}

Console.Write(NumM());

// 2. ВАРИАНТ:
// int Check(int num)
// {
//     int count = 0;

//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write($"Число {i}: ");
//         int a = int.Parse(Console.ReadLine());
//         if (a > 0) count++;
//     }
//     return count;
// }

// Console.Write("Сколько чисел хотите ввести?: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество чисел > 0: {Check(a)}");
