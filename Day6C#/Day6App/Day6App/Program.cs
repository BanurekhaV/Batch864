using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6App
{

    class GenDay6
    {
        public void Show<T>(string msg, T val)
        {
            Console.WriteLine("{0} : {1}", msg, val);
        }
    }
    class Program
    {
               
        static void Main(string[] args)
        {
            GenDay6 g6 = new GenDay6();
            //calling generic method
            g6.Show<int>("Integer", 125);
            g6.Show<char>("Character", 'A');
            g6.Show<double>("Double", 125.678);
            Console.Read();
        }
    }
}
