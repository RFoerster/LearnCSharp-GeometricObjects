﻿using System;
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
            GraphicCircle gc = new GraphicCircle();
            Console.WriteLine("Die Anzahl der Kreise = {0}", GraphicCircle.CountCircles);
            Console.ReadLine();
        }
    }
}
