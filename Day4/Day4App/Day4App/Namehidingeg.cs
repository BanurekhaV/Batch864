using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    class A1
    {
        public int i = 0;

        public void Method1(string s)
        {
            Console.WriteLine("Message from Base class {0}", s);
        }
    }

    class B1 : A1
    {
         new int i; // hiding the member from the base class 

        public B1(int a, int b)
        {
            base.i = a;
            i = b;
        }

        public new void Method1(string str) // method hiding from base class
        {
            Console.WriteLine("i from A1 {0}", base.i);
            Console.WriteLine("i from B1 {0}", i);
            Console.WriteLine("Message from Derived class {0}", str);
        }
    }
    class Namehidingeg
    {
        static void Main()
        {
            //B1 obj = new B1(5, 15);
            //obj.Method1("Hello i am hiding details from base");
            A1 a = new B1(2,3);
            a.Method1("Hai from Derived");
            Console.Read();
        }
    }
}
