using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{

   public class Shape  // default access specifier of a class is internal
    {
      protected internal float R=2, L=5, B=2;
        
        public int testvar;
        internal int intvar;
        public virtual float Area()
        {
            return 3.14F * R * R;
        }

        public virtual float Circumference()
        {
            Console.WriteLine("Base here");
            return 2 * 3.14F * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length");
            L = float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth");
            B = float.Parse(Console.ReadLine());
           // Console.WriteLine(in)
        }

        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
             base.Circumference();
            return 2 * (L + B);

        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write("Enter Radius");
            R = float.Parse(Console.ReadLine());
        }
    }
    class OverrideEg
    {

        static void Main()
        {
            /*Rectangle R = new Rectangle();
            R.GetLB();
            Console.WriteLine("Area : {0}", R.Area());
            Console.WriteLine("Circumference  : {0}", R.Circumference());

            Circle C = new Circle();
                C.GetRadius();
            Console.WriteLine("Area : {0}", C.Area());
            Console.WriteLine("Circumference  : {0}", C.Circumference());*/
            Shape sobj = new Shape();
           // sobj.
            Shape s = new Rectangle();
          
           // Console.WriteLine("Area : " + s.Area());
            Console.WriteLine("Circumference :" +s.Circumference());

            Console.ReadLine();
        }
    }
}
