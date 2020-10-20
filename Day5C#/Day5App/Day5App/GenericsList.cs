using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5App
{
    class Employee
    {
       public int empid;
        public string name;
        public string companyname;
        float sal;

        public Employee(int id, string name, string cname)
        {
            empid = id;
            this.name = name;
            companyname = cname;
        }

        public override string ToString()
        {
            // return base.ToString();
            return string.Format("Empid: " + empid + "Empname: " + name + "CompanyName: " + companyname);
        }
    }
    class GenericsList
    {
        static void Main()
        {
            /* List<int> lst1 = new List<int>();
             lst1.Add(10);
             lst1.Add(60);
             lst1.Add(15);
             lst1.Add(50);
             lst1.Sort();

             foreach(int i in lst1)
             {
                 Console.WriteLine(i);
             }*/

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Red");
            d.Add(5, "Blue");
            d.Add(3, "Green");
            d.Add(2, "Yellow");
            d.Add(4, "Black");

            /* foreach(int x in d.Keys)
             {
                 Console.WriteLine(x);
             }

             foreach (string s in d.Values)
             {
                 Console.WriteLine(s);
             }
            foreach(KeyValuePair<int, string> kv in d)
             {
                 Console.WriteLine(kv.Key);
                 Console.WriteLine(kv.Value);
             }

             //to search for specific key or value
             Console.WriteLine("Enter the Key you want to search");
             int i = Convert.ToInt32(Console.ReadLine());
             if(d.ContainsKey(i))
             {
                 Console.Write(i + "represents" + d[i]);
             }
             else
             {
                 Console.WriteLine("Key not found");
             }*/
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee(101, "Olivia", "LTI"));
            emps.Add(new Employee(105, "Dhruv", "LTI"));

            emps.Add(new Employee(102, "D'Silva", "LTI"));

            emps.Add(new Employee(87, "Susan", "LTI"));

            foreach(Employee e in emps)
            {
                Console.WriteLine(e.ToString());
            }

            //or
            foreach (Employee e in emps)
            {
                Console.WriteLine(e.empid + "with name" + e.name + "Works for" + e.companyname);
            }
            emps.Sort();
           // Stack<Employee> empstack = new Stack<Employee>();
            Console.Read();

        }
        
    }
}
