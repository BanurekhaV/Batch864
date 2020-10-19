using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    class Indexerseg
    {
        private string[] words = new string[3];

        public string this[int x] //position for the indexer
        {
            get
            {
                string temp = words[x]; // to identify a position of the array
                return temp;
            }

            set
            {
                words[x] = value;
            }
        }

        /* public string this[float f] //position for the indexer
         {
             get
             {
                 string temp = words[0.1]; // to identify a position of the array
                 return temp;
             }

             set
             {
                 words[x] = value;
             }
         }*/
  
    static void Main()
    {
        Indexerseg ie = new Indexerseg();
        ie[0] = "Hello";
        ie[1] = "World";
        ie[2] = "of Indexers";
        Console.WriteLine(ie[0] + ie[1] + ie[2]);
        Console.Read();
    }
}

}
