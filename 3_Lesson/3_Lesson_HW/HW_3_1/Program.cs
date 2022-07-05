// Палиндром — это такие слова, числа или символы,
// которые читаются одинаково в обоих направлениях.
// Палиндромы бывают образованы одним словом,
// состоящим из 1-2 символов, а могут быть 
// образованы целыми текстами.

// 1.Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// void Palindrome(int n)
// {
//     int i = 0;
//     string num = n.ToString();
//     int size = num.Length - 1;
//     string flag = "Нет";

//     while (i < size / 2)
//     {
//         if (num[i] == num[size - i])
//         {
//             flag = "Да";
//             break;
//         }
//         i += 1;
//     }
//     Console.WriteLine($"{n} -> {flag}");
// }

// Palindrome(14212);
// Palindrome(12821);
// Palindrome(23432);

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "Да";

    while (i < size / 2)
    {
        if (num[i] != num[size - i])
        {
            flag = "Нет";
            break;
        }
        i += 1;
    }
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome(14212);
Palindrome(12821);
Palindrome(23432);
Palindrome(1248421);
Palindrome(12488421);
