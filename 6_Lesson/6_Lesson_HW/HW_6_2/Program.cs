// 2. Напишите программу, которая найдёт точку пересечения двух прямых,
//    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//    значения b1, k1, b2 и k2 задаются пользователем.
//    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// https://studok.net/obrazovanie-i-kommunikacii/vopros-kak-vychislit-tochku-peresechenija-dvuh-prjamyh/


void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
     double y = k1 * x + b1;
     Console.WriteLine($"Точка пересечения: ({x}; {y})");
}

Intersection(2, 5, 4, 9);
