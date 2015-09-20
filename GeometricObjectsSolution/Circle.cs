using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace GeometricObjectsSolution
{
    //--------- EventHandler--------------------

    public delegate void InvalidMeasureEventhandler(Circle sender, InvalidMeasureEventArgs e);

    public class InvalidMeasureEventArgs : EventArgs
    {
        private int _InvalidMeasure;
        private string _PropertyName;
        public int InvalidMeasure
        {
            get { return _InvalidMeasure; }
        }

        public string PropertyName
        {
            get { return _PropertyName; }
        }

        public InvalidMeasureEventArgs(int invalidMeasure, string propertyName)
        {
            _InvalidMeasure = invalidMeasure;
            if (propertyName == null || propertyName == "")
            {
                _PropertyName = "[unknown]";
            }
            else
            {
                _PropertyName = propertyName;
            }
        }
    }





    public class Circle : GeometricObject
    {

        //--------------Ereignisse---------------
        public event InvalidMeasureEventhandler InvalidMeasure;

        public virtual void OnInvalidMeasure(InvalidMeasureEventArgs e)
        {
            if (InvalidMeasure != null)
                InvalidMeasure(this, e);
        }


        // -------------Klasseneigenschaft-----------------

        protected static int _CountCircles;
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

        protected int _Radius;

        public virtual int Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                {
                    _Radius = value;
                    OnPropertyChanged("RADIUS");
                }
                    
                else if (InvalidMeasure !=null)
                    OnInvalidMeasure(new InvalidMeasureEventArgs(value, "Kreis links hinten"));
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
