using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6App
{
    public delegate int delcal(int x);

    class sample
    {
        static int p;

        public int Square(int a)
        {
            p = a * a;
            return p;
        }

        public int triple(int q)
        {
            p = q * q * q;
            return p;
        }
    }
    class MulticastDel
    {
        public static void Main()
        {
            sample s = new sample();
            delcal dc1 = new delcal(s.Square);
            delcal dc2 = new delcal(s.triple);
            delcal dcall;
            dcall = dc2 + dc1;//multicast delegates +=/ -= /+ /-
            int result = dcall(5); 
            Console.WriteLine(result);
            Console.Read();
        }

    }
}
