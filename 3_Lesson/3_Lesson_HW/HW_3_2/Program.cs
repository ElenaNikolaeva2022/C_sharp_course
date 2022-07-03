// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
// Формулы вычисления расстояния между двумя точками:
// A(xa, ya, za) и B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double XYZ(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
XYZ(3, 6, 8, 2, 1, -7);
Console.WriteLine(XYZ(3, 6, 8, 2, 1, -7));