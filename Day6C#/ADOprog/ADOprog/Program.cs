using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOprog
{
    class Program
    {
        public static SqlConnection con = new SqlConnection();//connection object
        public static SqlCommand cmd = new SqlCommand();//command object
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            // InsertData();
            // DeleteData();
            // Selectdata();
            ProcedureCall();

            Console.Read();
            
        }

        private static void ProcedureCall()
        {
            con = GetConnection();
            cmd = new SqlCommand("Ten Most Expensive Products", con);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            }
        }
        private static void DeleteData()
        {
            con = GetConnection();
            Console.WriteLine("Enter Empid to be deleted");
            int eid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("select * from tblemployee where ID=@id",con);
            cmd1.Parameters.AddWithValue("@id", eid);
           SqlDataReader dr1= cmd1.ExecuteReader();
            while(dr1.Read())
            {
                for(int i=0;i<dr1.FieldCount;i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to delete this record Y/N");
            string answer = Console.ReadLine();
            if(answer=="y" || answer=="Y")
            {
                cmd = new SqlCommand("delete from tblemployee where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", eid);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    Console.WriteLine("Record deleted successfully");
                }
                else
                {
                   Console.WriteLine("Record not deleted ");
                }
            
            }

        }
        public static void InsertData()
        {
            con = GetConnection();
            //static insertion
            /* cmd = new SqlCommand("insert into tblemployee values('batch864',10000,'M',2)", con);
             int nor=cmd.ExecuteNonQuery();
             if(nor>0)
             {
                 Console.WriteLine("Inserted successfully");
             }
             else
             {
                 Console.WriteLine("Unsuccesful");
             }*/

            //dynamic insertion

            Console.WriteLine("Enter Name, Salary, Gender of the employee");
            string ename = Console.ReadLine();
            float esalary = float.Parse(Console.ReadLine());
            string egender = Console.ReadLine();
            int edept = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("insert into tblemployee values(@name,@salary,@gender,@dept)");
            
            cmd.Parameters.AddWithValue("@name", ename);

            cmd.Parameters.AddWithValue("@salary", esalary);
            cmd.Parameters.AddWithValue("@gender", egender);
            cmd.Parameters.AddWithValue("@dept", edept);
            cmd.Connection = con;
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine("Record Inserted successfully");
            }
            else
            {
                Console.WriteLine("Insertion Unsuccesful");
            }

        }
        private static void Selectdata()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from tblEmployee", con);// 1st method
            //cmd=new Sqlcommand("Select * from tblemployee");
            // cmd.Connection(con);
           dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4]);
               // Console.WriteLine("Empid:" + dr[0]);
            }
        }
        static SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=Northwind;Integrated Security=true");
            con.Open();
            return con;
        }
    }
}
