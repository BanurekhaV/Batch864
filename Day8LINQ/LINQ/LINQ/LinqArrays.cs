using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Students
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

        public Students(int rollno, string name, string city, string gender)
        {
            this.RollNo = rollno;
            this.Name = name;
            this.City = city;
            this.Gender = gender;
        }
    }
    class LinqArrays
    {
        string[] books = { "English", "Comp Science", "Maths", "Grid Computing" };
        static int[] Marks = { 97, 90, 78, 67, 89, 100 };

        #region StringOperations


        #endregion

        #region IntArrayOperations
        static void IntArrays()
        {
            //min function
            Console.WriteLine("Minimum Marks: {0}", Marks.Min());

            IEnumerable<int> marray = from m in Marks
                                      where m > 80 && m < 100
                                      select m;

            foreach(var item in marray)
            {
                Console.WriteLine(item);
            }

            //to count no.of students in the above category
            int count = (from m in Marks
                         where m > 80 && m < 100
                         select m).Count();
            Console.WriteLine("No.of Stdents scoring above 80 {0}", count);
        }
        #endregion

        void WorkwithList()
        {
            List<Students> stud = new List<Students>();
            stud.Add(new Students(101, "Gunjan", "Mumbai", "Female"));
            stud.Add(new Students(102, "Dhivya", "Mumbai", "Female"));
            stud.Add(new Students(103, "Dhruv", "Pune", "male"));
            stud.Add(new Students(104, "Abhi", "Kolkatta", "Male"));

            var studcity = from s in stud
                           where s.City.Equals("Mumbai")
                          select s.Name;

            foreach(var st in studcity)
            {
                Console.WriteLine(st);

            }
        }

        //GroupBy and OrderBy
        void OrderGroup()
        {
            List<Students> stud = new List<Students>();
            stud.Add(new Students(101, "Gourang", "Mumbai", "Male"));
            stud.Add(new Students(102, "Bhupesh", "Mumbai", "Male"));
            stud.Add(new Students(103, "Arnab", "Pune", "male"));
            stud.Add(new Students(104, "Yash", "Kolkatta", "Male"));
            stud.Add(new Students(105, "Rakshanda", "Kolkatta", "Female"));
            stud.Add(new Students(106, "Susan", "Bangalore", "Female"));


            IEnumerable<Students> st = from s in stud
                                       orderby s.Name, s.Gender
                                       select s;

            foreach(var student in st)
            {
                Console.WriteLine("{0}  {1}  {2} ", student.Name, student.Gender, student.City);
            }
            Console.WriteLine("-------Group By----------");
            Console.WriteLine("No. of Males and No.of Females");

            var gendercount = from s in stud
                              group s by s.Gender;

            foreach(var g in gendercount)
            {
                Console.WriteLine(g.Key + " " + g.Count());
            }
        }

        static void Main()
        {
            LinqArrays la = new LinqArrays();
            IntArrays(); // static method
            la.WorkwithList();
            la.OrderGroup();
            Console.Read();
        }

    }

    
}
