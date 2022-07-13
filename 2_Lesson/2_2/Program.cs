// 2. Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8   12-> 2   85 -> 8 

int MaxNum(int num)
{
    if (num % 10 > num / 10)
    {
        return num % 10;
    }
    else
        return num / 10;
}

int SecondNum = new Random().Next(10, 100);
Console.WriteLine(SecondNum);
Console.WriteLine(MaxNum(SecondNum));

