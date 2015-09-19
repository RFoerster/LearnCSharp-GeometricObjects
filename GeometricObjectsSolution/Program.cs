using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle Kreis = new Circle();
            Kreis.Radius = -100;
            Kreis.XCoordinate = 1.5;
            Kreis.YCoordinate = -4.5;
            Console.WriteLine("Der Radius des Kreises ist {0}, die XCoordinate ist {1} und die YCoordinate ist {2}", Kreis.Radius, Kreis.XCoordinate, Kreis.YCoordinate);
            Kreis.Move(20, 40);
            Console.WriteLine("Der Radius des Kreises ist {0}, die XCoordinate ist {1} und die YCoordinate ist {2}", Kreis.Radius, Kreis.XCoordinate, Kreis.YCoordinate);

            Console.ReadLine();
        }
    }
}
