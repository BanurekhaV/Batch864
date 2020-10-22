using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Day7App
{
    class Storedprocoutput
    {
       public static SqlConnection con = null;
       public static SqlCommand cmd;
        
       static SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source =DESKTOP-PU8R89M\\BRSQL;Initial Catalog = dbStudy ;Integrated Security=true");
            con.Open();
            return con;
        }

       static void procedurecall()
        {
            con = GetConnection();
            Console.WriteLine("Enter Emp Id");

            int csvariable = Convert.ToInt32(Console.ReadLine());
            
            cmd = new SqlCommand("proc2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inParam", csvariable);
          
            // cmd.Parameters.Add("@retParam", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
             //or as below

            
            SqlParameter outPutParameter = new SqlParameter();
            outPutParameter.ParameterName = "outsal";
            outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
            outPutParameter.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(outPutParameter);

           cmd.ExecuteNonQuery();



            // Get the values

            //int retval = (int)cmd.Parameters["@retParam"].Value;

            int outval = (int)cmd.Parameters["@outsal"].Value;

            Console.WriteLine("Employee salary is {0}", outval);

            //Console.WriteLine("Return value: {0}, Out value: {1}", retval, outval);

            con.Close();
        }
        public static void Main()
        {
            Storedprocoutput.procedurecall();
            Console.Read();
        }
    }

        
   
}
