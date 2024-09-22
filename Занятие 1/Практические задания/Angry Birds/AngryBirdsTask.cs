using System;

namespace AngryBirds
{
    public static class AngryBirdsTask
    {
        public static double FindSightAngle(double v, double distance)
        {
            double g = 9.8;
            return 0.5 * Math.Asin(distance * g / (v * v));
        }

        static void Main(string[] args)
        {

            double distance = Convert.ToDouble(Console.ReadLine());

            double v = Convert.ToDouble(Console.ReadLine());
        }


    }
}
