// Варианты записи
// Развёрнутый вариант:
// string num_str = Console.ReadLine();
// int num = int.Parse(num_str);

// Компактный вариант. И в терминале пишем любую цифру:
// например прибаим к числу 10. СЛОЖЕНИЕ.
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(num + 10);

// 0. Демонстрация решения. 
// Напишите программу, которая на вход принимает число 
// и выдаёт его квадрат (число умноженное на само себя). 
// Например: 
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(num * num);

// Ещё можно сделать красиво:
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"{num}^2: {num * num}");

// 1. Напишите программу, которая на вход принимает 
// два числа и проверяет, является ли первое число квадратом второго. 

// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да 

// Решение Марии:
// string s_a = Console.ReadLine();
// string s_b = Console.ReadLine();
// int a = int.Parse(s_a);
// int b = int.Parse(s_b);
// if (b == a * a)
// {
// Console.WriteLine("Yes");
// }
// else
// {
//   Console.WriteLine("No");  
// }


int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num2 == num1 * num1)
{
Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");  
}