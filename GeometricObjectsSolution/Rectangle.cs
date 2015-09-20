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

        protected static int _CountRectangles;
        public static int CountRectangles
        {
            get { return _CountRectangles; }
        }

        // -------------Konstruktoren-----------------

        public Rectangle() : this(0, 0, 0, 0) { }
        public Rectangle(int l, int b) : this(l, b, 0, 0) { }
        public Rectangle(int l, int b, double x, double y)
        {
            Laenge = l;
            Breite = b;
            XCoordinate = x;
            YCoordinate = y;
            Rectangle._CountRectangles++;
        }

        // -------------Eigenschaften-----------------

        protected int _Laenge;

        public virtual int Laenge
        {
            get { return _Laenge; }
            set
            {
                if (value >= 0)
                    _Laenge = value;
                else
                    Console.WriteLine("Unzulässige negative Länge.");
            }
        }

        protected int _Breite;

        public virtual int Breite
        {
            get { return _Breite; }
            set
            {
                if (value >= 0)
                    _Breite = value;
                else
                    Console.WriteLine("Unzulässige negative Breite.");
            }
        }

        // -------------Instanzmethoden-----------------

        public override double GetArea()
        {
            return Laenge*Breite;
        }

        public override double GetCircumference()
        {
            return (2 * Laenge) + (2 * Breite);
        }

        public virtual void Move(double dx, double dy, int dl, int db)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Laenge += dl;
            Breite += db;
        }

        public override string ToString()
        {
            return "Rectangle, Fläche=" + GetArea();
        }

        // -------------Klassenmethoden-----------------

        public static double GetArea(int l, int b)
        {
            return l * b;
        }

        public static double GetCircumference(int l, int b)
        {
            return (2 * l) + (2 * b);
        }

    }
}
