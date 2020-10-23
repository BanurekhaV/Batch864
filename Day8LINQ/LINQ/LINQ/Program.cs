using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ
{
    class Student
    {
        int id;
        string name;
        public int ID { get; set; }
        public string Name
        {

            get { return name; }
            set { name = value; }
        }

        public static List<Student> GetStudDetails()
        {
            List<Student> stud = new List<Student>();
            Student s1= new Student { ID = 101, Name = "Nikhita" };
            Student s2 = new Student { ID = 104, Name = "nikhil" };
            Student s3 = new Student { ID = 105, Name = "Priya" };
            Student s4 = new Student { ID = 103, Name = "Nand" };
            stud.Add(s1);
            stud.Add(s2);
            stud.Add(s3);
            stud.Add(s4);
            return stud;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            /* int[] numbers = { 7, 99, 45, 53 };
             var res = from n in numbers         // querying a collection
                       where n > 50
                       orderby n
                       select n.ToString();

             foreach(var item in res)
             {
                 Console.WriteLine(item);
             }*/

            IEnumerable<string> queryname = from stud in Student.GetStudDetails()
                                            where stud.Name.StartsWith("N") // stud.ID==105
                                            select stud.Name;

            foreach(var s in queryname)
            {
                Console.Write(s + " ");
            }


            Console.Read();
            
        }
    }
}
