using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // connected Architecture
 
            String ConnectionString = "Server=DESKTOP-4C2CAEV\\SQLEXPRESS; database=Fullstack; Integrated Security=SSPI";
            
            // select query
            //using (SqlConnection con = new SqlConnection(ConnectionString))
            //{
            //    SqlDataReader reader = null;
            //    con.Open();

            //    SqlCommand cmd = new SqlCommand("Select * from Department", con);


            //    reader = cmd.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        Console.WriteLine(reader[1]);
            //        //Console.WriteLine(reader[2]);
            //    }

            //    con.Close();
            //}



            //--------------insert query
            //Console.WriteLine("Enter dept name : ");
            //string deptName = Console.ReadLine();

            //Console.WriteLine("Enter HOD Name : ");
            //string HodName = Console.ReadLine();

            //using (SqlConnection con1 = new SqlConnection(ConnectionString))
            //{
            //   // SqlDataReader reader1 = null;
            //    con1.Open();

            //    SqlCommand cmd1 = new SqlCommand("insert into Department(deptName, HodName) values('"+deptName+"','"+HodName+"')", con1);
            //    int rowsAffected = cmd1.ExecuteNonQuery();
            //    if (rowsAffected > 0)
            //    {
            //        Console.WriteLine("Data inserted successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to insert data.");
            //    }
            //    con1.Close();
            //}


            //----update query
            //Console.WriteLine("Enter Department name to Update");
            //String deptName1 = Console.ReadLine();
            //Console.WriteLine("Enter HOD Name ");
            //String hodName = Console.ReadLine();



            //using(SqlConnection con2 = new SqlConnection(ConnectionString))
            //{
            //    con2.Open();

            //    SqlCommand cmd2 = new SqlCommand("update Department set deptName = '"+deptName1+"' where HodName = '"+hodName+"'", con2);


            //    int rowsAffected = cmd2.ExecuteNonQuery();
            //    if (rowsAffected > 0)
            //    {
            //        Console.WriteLine("Data Updated successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to update data.");
            //    }
            //    con2.Close();
            //}


            // -------delete query
            //Console.WriteLine("Enter Department name to delete : ");
            //String deptName = Console.ReadLine();


            //using(SqlConnection con3 = new SqlConnection(ConnectionString))
            //{
            //    con3.Open();
            //    SqlCommand cmd3 = new SqlCommand("delete from /*Department*/ where deptName = '" + deptName + "'", con3);

            //    int rowAffected = cmd3.ExecuteNonQuery();
            //    if(rowAffected > 0)
            //    {
            //        Console.WriteLine("Data deleted successfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to Delete data");
            //    }

            //    con3.Close();
            //}





            // ------ AddWithValue to insert
            //Console.WriteLine("Enter the Departmanet name: ");
            //String deptName = Console.ReadLine();

            //Console.WriteLine("Enter the Hod Name : ");
            //String hodName = Console.ReadLine();


            //using(SqlConnection con4 = new SqlConnection(ConnectionString))
            //{
            //    con4.Open();

            //    SqlCommand cmd4 = new SqlCommand("insert into Department(deptName, HodName) values(@d1, @h1)", con4);
            //    cmd4.Parameters.AddWithValue("@d1", deptName);
            //    cmd4.Parameters.AddWithValue("@h1", hodName);

            //    int rowAffected = cmd4.ExecuteNonQuery();
            //    if(rowAffected > 0)
            //    {
            //        Console.WriteLine("Data inserted succeessfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to insert data");
            //    }


            //    con4.Close();
            //}






            // ----- Add to insert
            //Console.WriteLine("Enter the Departmanet name: ");
            //String deptName = Console.ReadLine();

            //Console.WriteLine("Enter the Hod Name : ");
            //String hodName = Console.ReadLine();


            //using (SqlConnection con4 = new SqlConnection(ConnectionString))
            //{
            //    con4.Open();

            //    SqlCommand cmd4 = new SqlCommand("insert into Department(deptName, HodName) values(@d1, @h1)", con4);
            //    cmd4.Parameters.Add("@d1", SqlDbType.VarChar).Value = deptName;
            //    cmd4.Parameters.Add("@h1", SqlDbType.VarChar).Value = hodName;

            //    int rowAffected = cmd4.ExecuteNonQuery();
            //    if (rowAffected > 0)
            //    {
            //        Console.WriteLine("Data inserted succeessfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to insert data");
            //    }


            //    con4.Close();
            //}



            // ----- using stored procedure
            //Console.WriteLine("Enter Operation : ");
            //String opt = Console.ReadLine();

            //Console.WriteLine("Enter Department id : ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Department : ");
            //String department = Console.ReadLine();

            //Console.WriteLine("Enter Hod Name : ");
            //String hodName1 = Console.ReadLine();

            //using (SqlConnection con5 = new SqlConnection(ConnectionString))
            //{
            //    con5.Open();
            //    SqlCommand cmd5 = new SqlCommand("DeptInsertUpdateDelete", con5)
            //    {
            //        CommandType = CommandType.StoredProcedure
            //    };

            //    cmd5.Parameters.AddWithValue("@operation", opt);
            //    cmd5.Parameters.AddWithValue("@deptId", id);
            //    cmd5.Parameters.AddWithValue("@deptName", department);
            //    cmd5.Parameters.AddWithValue("@hodName", hodName1);



            //    int rowAffected = cmd5.ExecuteNonQuery();
            //    if(rowAffected > 0)
            //    {
            //        Console.WriteLine("Data iserted successfully");
            //    }

            //}
           




            // -- disconnected Architecture         // adapter

            using (SqlConnection con4 = new SqlConnection(ConnectionString))
            {
                con4.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Department", con4);
                Console.WriteLine(adapter);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine(row[1]);
                }

                con4.Close();
            }

            Console.Read();

        }
    }
}
