using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5App
{
    public class IPL<T>
    {
        private T data;

        //use properties

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }
    class Generics1
    {
        static void Main()
        {
            IPL<string> cric = new IPL<string>();
            cric.Data = "Mumbai Indians";
            Console.WriteLine(cric.Data);
            IPL<int> intcric = new IPL<int>();
            intcric.Data = 5;
            Console.WriteLine(intcric.Data);

            Console.Read();
        }
    }
}
