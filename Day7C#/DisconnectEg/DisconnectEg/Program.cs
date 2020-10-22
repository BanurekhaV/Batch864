using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DisconnectEg
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
           // SqlCommand cmd;
            SqlDataAdapter da;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-PU8R89M\\BRSQL; Initial Catalog=Northwind; Integrated Security=true");
                da = new SqlDataAdapter("select * from Region", con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "NorthwindRegion");
                DataTable dt = ds.Tables["NorthwindRegion"];

                foreach(DataRow r in dt.Rows)
                {
                    foreach(DataColumn c in dt.Columns)
                    {
                        Console.Write(r[c]);
                        Console.WriteLine(" ".PadLeft(20,'='));
                    }
                    Console.WriteLine(" ");
                }
                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.Fill(ds);
                //Lets us Add one more table to the same Dataset
                Console.WriteLine("----------------------");
                da = new SqlDataAdapter("select * from Shippers", con);
                da.Fill(ds, "NorthwindShipper");
                dt = ds.Tables["NorthwindShipper"];
                foreach (DataRow r1 in dt.Rows)
                {
                    foreach (DataColumn c1 in dt.Columns)
                    {
                        Console.Write(r1[c1]);
                        Console.Write(" ");
                       // Console.WriteLine(" ".PadLeft(20, '='));
                    }
                    Console.WriteLine(" ");
                }

                //Insert Record into Region Table

               
                              //inserting one row into Datatable Northwind Region
                DataRow row = ds.Tables["NorthwindRegion"].NewRow();
                row["RegionID"] = 10;
                row["RegionDescription"]= "NorthWest";
                //add the new row with data to Dataset
                ds.Tables["NorthwindRegion"].Rows.Add(row);
                
                da.UpdateCommand = scb.GetUpdateCommand();
                da.Update(ds.Tables[1]);
                               
              //  Console.WriteLine(res);
                Console.WriteLine("---------------");
                dt = ds.Tables["NorthwindRegion"];

                foreach (DataRow r2 in dt.Rows)
                {
                    foreach (DataColumn c2 in dt.Columns)
                    {
                        Console.Write(r2[c2]);
                        Console.Write(" ");
                        // Console.WriteLine(" ".PadLeft(20, '='));
                    }
                    Console.WriteLine(" ");
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();

        }
    }
}
