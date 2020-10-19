using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestDLL
{
    public class Class1
    {
        public int Multiply(int x, int y)
        {
            x += 2;
            int res = x * y;
            return res;
        }
    }
}
