using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5App
{

    class Student
    {
        public dynamic Total<T>(T Maths, T Science, T English)
        {
            dynamic m = Maths;
            dynamic s = Science;
            dynamic e = English;
            return m + s + e;
        }

        
       // public void GetDetails<T>()
    }
    class GenericsAll
    {
        static void Main()
        {
            Student sobj = new Student();
            double tot = sobj.Total<float>(85.5f, 90.5f, 76.5f);
            Console.WriteLine(tot);

            string result = sobj.Total<string>("A", "B", "C");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
