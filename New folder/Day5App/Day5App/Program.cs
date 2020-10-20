using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Day5App
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList Al = new ArrayList();
             Al.Add(10);
             Al.Add("Rama");
             Al.Add(24.10f);
             Al.Add("Krishna");
             Al.Add(true);
             Al.Insert(2, "Sita");
             Al.RemoveAt(3);


             ArrayList Al2 = new ArrayList();
             Al2.Add(5);
             Al2.Add(2);
             Al2.Add(1);
             Al2.Add(4);
             Al2.Sort();
             foreach (var item in Al)
             {
                 Console.WriteLine(item);

             }
             Console.WriteLine("Count of the List" + Al.Count);
             Console.WriteLine("Capacity of the List" + Al.Capacity);

             foreach (var item in Al2)
             {
                 Console.WriteLine(item);

             }
             Al.InsertRange(5, Al2);
            // Al.Sort();
             //Arraylist after insertion and sorting
             foreach(var item in Al)
             {
                 Console.WriteLine(item);

             }
             Console.WriteLine("Capacity of the List" + Al.Capacity);*/

            Hashtable ht = new Hashtable();
            ht.Add("E001", "Abhi"); // key and values can be of different data type
            ht.Add("E006", "Aniket");
            ht.Add("E003", "Shefali");
            ht.Add("E002", "Yash");
            ht.Add(3, null);

            /* foreach (var item in ht.Keys)
             {
                 Console.WriteLine(item);
             }

             foreach (var item in ht.Values)
             {
                 Console.WriteLine(item);
             }

             //inorder to get both key and values, we use DictionaryEntry
             foreach (DictionaryEntry de in ht)
             {
                 Console.Write(de.Key);
                 Console.Write(de.Value);
                 Console.WriteLine();
             }
             ht["E003"] = "Rakshanda";
                 Console.WriteLine(ht["E003"]);*/

            /* SortedList sl = new SortedList();
             sl.Add("ora", "Oracle");
             sl.Add("C#", "CSHARP");
             sl.Add("vb", "Vb.Net");


             foreach (DictionaryEntry ds in sl)
             {
                 Console.WriteLine(ds.Key + " " + ds.Value);

             }*/

            Stack st = new Stack();
            st.Push(2);// to add to the stack
            st.Push(4);
            st.Push(6);
            st.Push(8);

            foreach(object o in st)
            {
                Console.WriteLine(o);
            }
            st.Pop();// to remove an element in the stack
            foreach (object o in st)
            {
                Console.WriteLine(o);
            }

            Queue q = new Queue();
            q.Enqueue("Charp.Net");
            q.Enqueue("VB.Net");
            q.Enqueue("ASP.Net");
            q.Enqueue("SQL");
            foreach (object o in q)
            {
                Console.WriteLine(o);
            }
            q.Dequeue();// to remove an element in the queue
            foreach (object o in q)
            {
                Console.WriteLine(o);
            }

            Console.Read();
        }
    }
}
