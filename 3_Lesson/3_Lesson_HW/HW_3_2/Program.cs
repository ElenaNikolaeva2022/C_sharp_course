<<<<<<< HEAD
﻿// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
// Формулы вычисления расстояния между двумя точками:
// A(xa, ya, za) и B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double AB(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}

Console.WriteLine(AB(3, 6, 8, 2, 1, -7));

// double Line3D(float x1, float y1, float z1, float x2, float y2, float z2)
// {
//   return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);  
// }
// Console.WriteLine(Line3D(3, 6, 8, 2, 1, -7));
// Console.WriteLine(Line3D(7, -5, 0, 1, -1, 9));


=======
﻿
>>>>>>> 4_lesson
