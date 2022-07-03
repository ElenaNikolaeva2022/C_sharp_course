// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
// Формулы вычисления расстояния между двумя точками:
// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) 
// на плоскости:// AB = √(xb - xa)2 + (yb - ya)2

// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.

double XY(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
XY(3, 6, 9, 4);
Console.WriteLine(XY(3, 6, 9, 4));