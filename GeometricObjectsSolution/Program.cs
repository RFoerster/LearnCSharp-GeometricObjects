using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;   

namespace GeometricObjectsSolution
{


    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList { "Robert", "Markus", "Papa", "Ines" };
            Console.WriteLine("-------------Schreibe Liste-------------");
            PrintListe(liste);
            Console.WriteLine("Liste geschrieben \n\n");
            liste.Remove("Robert");
            Console.WriteLine("-------------Schreibe neue Liste --------------");
            PrintListe(liste);
            Console.ReadLine();

        }

        static void PrintListe(IList liste)
        {
            foreach (string item in liste)
                Console.WriteLine("Index: {0,-3} {1}", liste.IndexOf(item), item);
        }
    }
}
