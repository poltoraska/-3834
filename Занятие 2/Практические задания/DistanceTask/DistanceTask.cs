using System;

namespace DistanceTask;

public static class DistanceTask
{
    // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
    public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
    {
        if (ax == ay && ay == bx && bx == by && by == x && x == y) // если отрезок и  точка  - это все  одна точка
            return 0;
        if (ax == bx && ay == by)                                            //на случай если отрезок представляет собой  точку
            return Math.Sqrt(Math.Pow((x - ax), 2) + Math.Pow((y - ay), 2));      

        double t = ((x - ax) * (bx - ax) + (y - ay) * (by - ay)) / (Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
        t = t < 0 ? 0 : t > 1 ? 1 : t;
        return (double)Math.Sqrt(Math.Pow((ax - x + (bx - ax) * t), 2) + Math.Pow((ay - y + (by - ay) * t), 2));
        // записываю уравнение точки отрезка параметрически; при t=0 это точка A, при 1 - точка B. Нахожу минимум, дифференцируя l^2(l это расстояние которое ищем). При t, выходящем за рамки отрезка, рассматриваю расстояние до ближайшей точки. 
    }
}
