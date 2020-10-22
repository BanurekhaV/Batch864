using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Transcope
{
    class Program
    {
        static void LocalTransaction()
        {
            string myconnection = "Data Source=DESKTOP-PU8R89M\\BRSQL; Initial Catalog = Northwind; Integrated Security =true";
            using (TransactionScope myscope = new TransactionScope())
            {
                using (var myconn = new SqlConnection(myconnection))
                {
                    myconn.Open();
                    try
                    {
                        var mycommand1 = new SqlCommand("insert into Region values(10,' SW')", myconn);
                        int i = mycommand1.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("Region Inserted");
                        }
                        else
                        {
                            Console.WriteLine("Region Not inserted");
                        }
                        var mycommand2 = new SqlCommand("insert into Shippers values('Amazon', '65335376'", myconn);
                        int j = mycommand2.ExecuteNonQuery();

                        if (j > 0)
                        {
                            Console.WriteLine("Shipper Inserted");
                        }
                        else
                        {
                            Console.WriteLine("Shipper Not inserted");
                        }
                        myscope.Complete();

                    }

                    catch (Exception e) { }
                }
            }


        }
        static void DistributedTransaction()
        {
            string str1 = "Data Source=DESKTOP-PU8R89M\\BRSQL; Initial Catalog = Northwind; Integrated Security =true";
            string str2 = "Data Source=DESKTOP-PU8R89M\\BRSQL; Initial Catalog = dbStudy; Integrated Security =true";

            using (TransactionScope myscope = new TransactionScope())
            {
                using (var myconn = new SqlConnection(str1))
                {
                    myconn.Open();
                    var cmd1 = new SqlCommand("Insert into Region values(10, 'SSW')", myconn);
                    int x = cmd1.ExecuteNonQuery();
                    using (var myconn1 = new SqlConnection(str2))
                    {
                        myconn1.Open();

                        var cmd2 = new SqlCommand("insert into tblemployee values('Rita', 11000,'Female', 2)", myconn1);

                        int y = cmd2.ExecuteNonQuery();
                    }
                }
                myscope.Complete();
            }
        }


        class driver
        {
            static void Main(string[] args)
            {
                // LocalTransaction();
                DistributedTransaction();
                Console.Read();
            }
        }
    }
}


