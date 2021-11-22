using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            double P1, S1;
            GetParam(x1, y1, z1, out P1, out S1);
            if (x1+y1>z1 && x1+z1>y1 && y1+z1>x1)
            {
                Console.WriteLine("{0:F2}", S1);
            }
            else
            {
                Console.WriteLine("error");
                Console.ReadKey();
                return;
            }
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            double P2, S2;
            GetParam(x2, y2, z2, out P2, out S2);
            if (x2 + y2 > z2 && x2 + z2 > y2 && y2 + z2 > x2)
            {
                Console.WriteLine("{0:F2}", S2);
            }
            else
            {
                Console.WriteLine("error");
                Console.ReadKey();
                return;
            }
            if (S1>S2)
            {
                Console.WriteLine("S1>S2");
            }
            else
            {
                Console.WriteLine("S1<S2");
            }
            Console.ReadKey();
        }
        static void GetParam(int x, int y, int z, out double P, out double S)
        {
            P = (((double)x) + ((double)y) + ((double)z))/ 2;
            S = Math.Sqrt(P*(P-x)* P * (P - y)* P * (P - z));
        }
    }
}
