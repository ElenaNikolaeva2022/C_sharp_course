// 1. Напишите программу, которая принимает на вход 
//    трёхзначное число и на выходе показывает последнюю 
//    цифру этого числа (456 - > 6) (782 - > 2) (918 - > 8)

int TakeNum(int num)
{
    // return 678 % 10 = 8;
    return num % 10;  
}

Console.WriteLine(TakeNum(678));
Console.WriteLine(TakeNum(6785));