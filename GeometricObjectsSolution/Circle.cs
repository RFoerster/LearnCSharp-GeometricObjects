using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class Circle
    {
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
                    Console.WriteLine("Ungültiger negativer Wert für Radius.");
            }
        }

        public double GetArea()
        {
            double area = Math.Pow(Radius, 2) * Math.PI;
            return area;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Radius * Math.PI;
            return circumference;
        }

        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public int Bigger(Circle kreis)
        {
            if (Radius > kreis.Radius) return 1;
            if (Radius < kreis.Radius) return -1;
            else return 0;
        }


      
    }
}
