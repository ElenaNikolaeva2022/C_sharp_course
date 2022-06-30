// 4.  Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend(int num)
{
    string text = "Нет";

    if (num == 7 || num == 6) text = "Да";
    Console.WriteLine($"{num} -> {text}");
}
Weekend(6);
Weekend(7);
Weekend(1);