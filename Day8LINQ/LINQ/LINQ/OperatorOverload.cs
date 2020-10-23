using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Distance
    {
        public int dist;

       /*( public int Dist   // int z= int x + int y;
        {
            get { return dist; }
            set { dist = value; }
        }*/
       //distance dt3= distance dt1 + distance dt2
        public static Distance operator +(Distance d1, Distance d2)
        {
            Distance temp = new Distance();
            temp.dist = d1.dist * d2.dist;
            return temp;
        }
    }
    class OperatorOverload
    {
        static void Main()
        {
            Distance dt1 = new Distance();
            Distance dt2 = new Distance();
            dt1.dist = 10;
            dt2.dist = 20;
            Distance dt3 = dt1 + dt2;

            Console.WriteLine("The totalDistance is {0}", dt3.dist);
            Console.Read();
        }
    }
}
