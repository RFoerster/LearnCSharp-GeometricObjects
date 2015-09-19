using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public abstract class GeometricObject
    {
        //--------------Klassenvariablen----------------
        private static int _CountGeometricObjects;
        public static int CountGeometricObjects
        {
            get { return _CountGeometricObjects; }
        }


        //-------------Konstruktor---------------
        protected GeometricObject()
        {
            _CountGeometricObjects++;
        }

        //------------- Instanzvariablen und Eigenschaftsmethoden----------
        public virtual double XCoordinate { get; set; }
        public virtual double YCoordinate { get; set; }

        //------------- Instanzmethoden----------

        public abstract double GetArea();
        public abstract double GetCircumference();

        public virtual int Bigger (GeometricObject @object)
        {
            if (@object == null || GetArea() > @object.GetArea()) return 1;
            if (GetArea() < @object.GetArea()) return -1;
            return 0;
        }

        public virtual void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        //---------- Klassenmethoden---------------
        public static int Bigger(GeometricObject object1, GeometricObject object2)
        {
            if (object1 == null || object2 == null) return 0;
            if (object1 == null) return -1;
            if (object2 == null) return 1;
            if (object1.GetArea() > object2.GetArea()) return 1;
            if (object1.GetArea() < object2.GetArea()) return -1;
            return 0;
        }
            
    }
}
