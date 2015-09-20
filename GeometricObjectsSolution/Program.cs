using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GeometricObjectsSolution
{
    public delegate double CalculateHandler(double value1, double value2);
    public delegate void SayHiHandler();

    class Program
    {
        static void Main(string[] args)
        {
            GraphicCircle kreis1 = new GraphicCircle(-10, 5, 4);
            kreis1.InvalidMeasure += kreis_InvalidMeasure;
            Console.WriteLine(kreis1.ToString());
            Console.ReadLine();
            kreis1.Radius = -1;
            Console.WriteLine(kreis1.ToString());
            Console.ReadLine();
            
                
        }

        private static void Kreis1_InvalidMeasure()
        {
            Console.WriteLine("Du bist dumm");
        }

        public static void kreis_InvalidMeasure(Circle sender, InvalidMeasureEventArgs e)
        {
            Console.Write("Unzulässiger negativer Radius ({0}), bitte neuen Radius für {1} eingeben:", e.InvalidMeasure, e.PropertyName);
            sender.Radius = Convert.ToInt32(Console.ReadLine());
        }
    }
}
