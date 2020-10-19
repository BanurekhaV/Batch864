using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    class Basederived
    {
        public int a;

        public Basederived(int a)
        {
           this.a = a;
        }

    }

    class Derived : Basederived
    {
        public int b;

        public Derived(int y): base(y)
        {
            b = y;
        }

        public Derived(int y, int z) : base(z)
        {
            b = y;
        }
    }

    class check
    {
        public static void Main()
        {
            Basederived bd = new Basederived(5);
            Basederived bd1;
            Derived d = new Derived(10);
            Derived D1 = new Derived(20, 30);
            bd1 = bd; // possible because both are of the same data type
            Console.WriteLine("BD:" + bd.a);
            Console.WriteLine("BD1:" + bd1.a);
            Console.WriteLine("D:" + D1.a);
            Console.WriteLine("D:" + D1.b);
            Console.Read();
        }
    }
}
