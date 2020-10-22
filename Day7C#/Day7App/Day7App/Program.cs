using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Day7App
{

    class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        internal void GetRegion()
        {
            Console.WriteLine("Enter REgion Id");
            RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description");
            RegionDescription = Console.ReadLine();
        }
    }

    class DataAccess
    {
        SqlConnection con = null;
        SqlCommand cmd;

          public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source =DESKTOP-PU8R89M\\BRSQL;Initial Catalog = Northwind ;Integrated Security=true");
            con.Open();
            return con;
        }

        public void DisplayRegion()
        {
            try
            {
                con = GetConnection();
                SqlDataReader dr;
                cmd = new SqlCommand("Select * from Region", con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr["RegionID"] + " " + dr["RegionDescription"]);
                }

            }
            catch(Exception e)
            {

            }
            finally
            {
                con.Close();
            }
        }

        internal void InvokeScalar()
        {
            con = GetConnection();
            cmd = new SqlCommand("select count(RegionId) from Region", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());//execute scalar return object
            Console.WriteLine("No of Regions :{0}", count);
        }

        internal void StoredProcedureCall()
        {
            con = GetConnection();
            Console.WriteLine("enter cust id");
            string custid = Console.ReadLine();
            cmd = new SqlCommand("CustOrdersOrders", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //just fo rinput parameters below command is sufficient
             cmd.Parameters.AddWithValue("@customerid", custid);

            //use the below when you have many parameters for both input and output parameters

            SqlParameter sqlparam = new SqlParameter();
            //("@Customerid", custid);
            sqlparam.Direction = ParameterDirection.Input;
            sqlparam.DbType = DbType.String;
            sqlparam.ParameterName = "CustomerId";
            sqlparam.Value = custid;
            cmd.Parameters.Add(sqlparam);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                Console.WriteLine(rdr["OrderId"] + " " + rdr["OrderDate"] + " " + rdr["RequiredDate"]);
                    }
            con.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            DataAccess dac = new DataAccess();
            try
            {
                //dac.InvokeScalar();
                // dac.DisplayRegion();
                dac.StoredProcedureCall();
            }
            catch(Exception e) { }
            Console.Read();
        }
        
    }
}
