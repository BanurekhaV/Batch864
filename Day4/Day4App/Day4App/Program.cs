using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTestDLL;

namespace Day4App
{
    class Program
    {
        static void Main(string[] args) 
        {
            //  this is a true OOP .exe assembly
            /* All are objects 
             * in a Object Oriented Prog
            Console.WriteLine("Hello World");
           // int result = Calculate(5, 6);
            Class1 c = new Class1();
            int res = c.Multiply(5, 3);
            Console.WriteLine(res);*/
            sample s = new sample();
            s.Name = "aaa";
            Console.WriteLine(s.Name);
                 
            Console.Read();
        }

        public static int Calculate(int x, int y)
        {
            return x + y;
        }
    }

    class sample
    {
        private string name ="Banu";
        private int age;
        private float salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age  // readonly property
        {
            get { return age; }
        }
        

        
    }
}
