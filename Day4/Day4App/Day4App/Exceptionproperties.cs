using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    class Exceptionproperties
    {
       static void Main()
        {
            int a, b, c=0;
            try
            {
                Console.WriteLine("Enter 2 nos");
                a = int.Parse(Console.ReadLine());
                b= int.Parse(Console.ReadLine());
                c = a / b;  // likeley to throw an exception if b's value is 0
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace +"" + e.Message + " "+ e.Source);
            }
            finally
            {
                Console.WriteLine("value of c" + c);
            }
            Console.Read();
        }
    }
}
