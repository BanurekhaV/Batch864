using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Employee
    {
         int ID;
         string Name;
        public int _ID
        {
            get;set;
        }
         public string _Name
        {
            get;set;
        }
    }
    class LambdaEg
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30 };

            //display

            Console.WriteLine("The List of Numbers is :");
            foreach(var v in numbers)
            { 
                Console.WriteLine("{0}", v);
            }
           

            //use of Lamba Expressions
            //1. Square of nos

            var square = numbers.Select(x => x * x);

            Console.WriteLine("Squares: ");

            foreach(var val in square)
            {
                Console.WriteLine("{0}", val);
            }

            List<Employee> emplist = new List<Employee>()
            {
                new Employee{_ID=101, _Name="Raj" },
                new Employee{_ID=102, _Name="Aniket" },
                new Employee{_ID=101, _Name="Shefali" }
            };

            Employee e = emplist.Find(emp => emp._ID == 102);
            Console.WriteLine("ID= {0}, Name is {1}", e._ID, e._Name);

            //to sort the list

            var empsort = emplist.OrderBy(x => x._Name);

            foreach(var v in empsort)
            {
                Console.WriteLine(v._ID + " " + v._Name);
            }
            Console.Read();
        }
    }
}
