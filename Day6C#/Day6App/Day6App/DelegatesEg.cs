using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6App
{
    public delegate void EmpDel(string s); // declaration of a delegate

    class Employee
    {
        public static void AcceptEmployee(string name)
        {
            Console.WriteLine("Hello" + " " + name);
        }
         public int getSalary(int sal)
        {
            return 0;
        }
        public void DisplayEmployee(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class DelegatesEg
    {
        static void Main()
        {
            Employee eobj = new Employee();
            EmpDel ed1 = new EmpDel(Employee.AcceptEmployee); // static method being given to a delegate Object
            ed1(" Hi Radha");
            EmpDel ed2 = new EmpDel(eobj.DisplayEmployee); // Instance method being given to a delegate Object
            ed2("Welcome to The World of Delegates");
            Console.Read();
        }
    }
}
