// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (Num > 0)
{
    int num = Num % 10;
    Num = Num / 10;
    sum = sum + num;
}

Console.WriteLine(sum);
