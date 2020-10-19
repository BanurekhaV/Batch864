using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4App;

namespace Accessspecifiersex
{
    class Program : Shape
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.B = 4;
            p.R = 2.4F;
            p.L = 4.5F;
            p.testvar = 19;
        }
    }
}
