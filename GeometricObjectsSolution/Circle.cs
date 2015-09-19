using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class Rectangle : GeometricObject
    {
        // -------------Klasseneigenschaft-----------------

        protected static int _CountCircles;
        public static int CountCircles
        {
            get { return _CountCircles; }
        }

        // -------------Konstruktoren-----------------

        public Rectangle() : this(0, 0, 0) { }
        public Rectangle(int radius) : this(radius, 0, 0) { }
        public Rectangle(int radius, double x, double y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            Rectangle._CountCircles++;
        }

        // -------------Eigenschaften-----------------

        protected int _Radius;

        public virtual int Radius
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

        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public virtual void Move(double dx, double dy, int dRadius)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Radius += dRadius;
        }

        public override string ToString()
        {
            return "Circle, R=" + Radius + ",Fläche=" + GetArea();
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

    }
}
