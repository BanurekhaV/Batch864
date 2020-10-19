using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    class Learning
    {
        public static void Main()
        {
            float f = 123464674878.56f;
            int x;
            //int x = (int)f;  // explicit conversion
           

            string str = "100";
            bool status = int.TryParse(str, out x);

            // x = int.tryParse(str);

            if (status)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Invalid data, cannot parse");
            }

            Console.Read();
        }
        
        
    }
}
