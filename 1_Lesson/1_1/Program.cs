//1. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго. 

// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

// string num_str = Console.ReadLine();
// int num = int.Parse(num_str);

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