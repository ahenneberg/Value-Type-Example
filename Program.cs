using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointer_Example
{
    class Program
    {
        // The assignment of a value-type always COPIES the instance.
        static void Main()
        {
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1;              //Assignment causes copy

            Console.WriteLine(p1.X);    // 7
            Console.WriteLine(p2.X);    // 7

            p1.X = 9;                   // Change p1.X

            Console.WriteLine(p1.X);    // 9
            Console.WriteLine(p2.X);    // 7
        }
    }
    public struct Point { public int X, Y; }
}
/*      This figure shows that p1 and p2 have independent storage
 *                              Point Struct
 *                        p1                    p2
 *                  _______________      _______________
 *                 |       9       |    |       7       |
 *                 |---------------|    |---------------|
 *                 |       0       |    |       0       |
 *                 |_______________|    |_______________|
     
     
     
     
     
     */