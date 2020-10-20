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

         public string this[float f] //position for the indexer
         {
             get
             {
                string temp = words[1]; // to identify a position of the array
                 return temp;
             }

             set
             {
                 words[1] = value;
             }
         }
  
    static void Main()
    {
            /*Indexerseg ie = new Indexerseg();
                ie[0.0f] = "5.5F";
            ie[1] = "10";
            ie[2] = "of Indexers";
            Console.WriteLine(ie[0] + ie[1] + ie[2]);*/
            Flowervase fv = new Flowervase();
            fv[0] = new Flower("Rose", "Red");
            fv[1]= new Flower("Lily", "White");
            fv[2]=new Flower("Hibiscus", "Pink");
            
            for(int i=0;i<3;i++)
            {
                fv[i].Display();
            }
            
            Console.Read();
    }
}

    public class Flower
    {
        string name;
        string color;

        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Display()
        {
            Console.WriteLine(name + "  " + "in" + " " + color + "Color");

        }
    }

    class Flowervase
    {
        Flower[] ob = new Flower[5];
        //indexers for flower
        public Flower this[int pos]
        {
            get { return ob[pos]; }
            set { ob[pos] = value; }
        }
        
    }
}
