using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class Circle
    {
        // -------------Klasseneigenschaft-----------------

        private static int _CountCircles;
        public static int CountCircles
        {
            get { return _CountCircles; }
        }

        // -------------Konstruktoren-----------------

        public Circle() : this(0, 0, 0) { }
        public Circle(int radius) : this(radius, 0, 0) { }
        public Circle(int radius, double x, double y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            Circle._CountCircles++;
        }

        // -------------Eigenschaften-----------------

        public double XCoordinate {get; set; }
        public double YCoordinate { get; set; }
        private int _Radius;

        public int Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                    _Radius = value;
                else
                    Console.WriteLine("Unzulässiger negativer Radius.");
            }
        }


        // -------------Instanzmethoden-----------------

        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public int Bigger(Circle kreis)
        {
            if (kreis == null || Radius > kreis.Radius) return 1;
            if (Radius < kreis.Radius) return -1;
            else return 0;
        }

        public void Move(double dx, double dy, int dRadius)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Radius += dRadius;
        }

        // -------------Klassenmethoden-----------------

        public static double GetArea(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public static double GetCircumference(int radius)
        {
            return 2 * radius * Math.PI;
        }

        public static int Bigger(Circle kreis1, Circle kreis2)
        {
            if (kreis1 == null && kreis2.Radius == 0) return 0;
            if (kreis1 == null || kreis1.Radius < kreis2.Radius) return -1;
            if (kreis2 == null || kreis2.Radius < kreis1.Radius) return 1;
            return 0;
        }
    }
}
