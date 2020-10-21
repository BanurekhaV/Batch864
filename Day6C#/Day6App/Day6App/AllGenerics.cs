using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6App
{
    class AllGenerics<T>
    {
        private T genericmember;

        public AllGenerics(T val)
        {
            genericmember = val;
        }

        public T Genericmember { get; set; }
        
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type : {0}, Value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type : {0}, Value: {1}", typeof(T).ToString(), genericmember);
            return genericmember;
        }
    }

    class test
    {
        static void Main()
        {
            AllGenerics<int> alg = new AllGenerics<int>(10);
            int x = alg.genericMethod(200);

            AllGenerics<string> algstr = new AllGenerics<string>("Mystring");
            string s = algstr.genericMethod("Generic method with string argument");
            Console.Read();
        }
    }
}
