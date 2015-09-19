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
            Object[] arr = new Object[3];
            arr[0] = new Rectangle(1, 2, 3);
            arr[1] = new Rectangle(3, 4, 5);
            arr[2] = new GraphicCircle(5, 6, 7);

            foreach (Object temp in arr)
            {
                Console.WriteLine(temp.ToString());
            }
            Console.ReadLine();
        }
    }
}
