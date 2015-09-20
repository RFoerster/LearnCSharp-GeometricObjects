using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public delegate double CalculateHandler(double value1, double value2);
    public delegate void SayHiHandler();

    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis1 = new Circle(-10, 5, 4);
            kreis1.InvalidMeasure += Kreis1_InvalidMeasure;
            kreis1.InvalidMeasure += kreis_InvalidMeasure;
            Console.WriteLine(kreis1.ToString());
            Console.ReadLine();
            kreis1.Radius = -1;
            Console.ReadLine();
            
                
        }

        private static void Kreis1_InvalidMeasure()
        {
            Console.WriteLine("Du bist dumm");
        }

        public static void kreis_InvalidMeasure()
        {
            Console.WriteLine("Unzulässiger negativer Radius.");
        }
    }
}
