using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    interface Icustomer
    {
        void Show();  // abstract method - no definition, only declaration
    }

    interface Isupplier
    {
        void Show();
    }
    class interfaceeg : Icustomer, Isupplier
    {
         public void Show()  // default method
        {
            Console.WriteLine("Customer Interface Method");
        }

       /*  void Icustomer.Show()  // default method
        {
            Console.WriteLine("Customer Interface Method");
        }*/
        void Isupplier.Show()
        {
            Console.WriteLine("Supplier Interface Method");
        }

        static void Main()
        {
            interfaceeg ieg = new interfaceeg();
            
           // ((Icustomer)ieg).Show(); // using interface reference variable
           // ((Isupplier)ieg).Show();  // or

            Icustomer ic1 = new interfaceeg();
           // Isupplier ic2 = new interfaceeg();
            ic1.Show();
           // ic2.Show();
            Console.Read();
            
        }
    }
}
