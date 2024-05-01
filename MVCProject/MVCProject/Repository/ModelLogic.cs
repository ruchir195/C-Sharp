using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

using MVCProject.Models;

namespace MVCProject.Repository
{
    public class ModelLogic
    {

        private string connectionString = "Server=DESKTOP-4C2CAEV\\SQLEXPRESS; database=AdoPractice; Integrated Security=SSPI";



        public DataTable SelectStudents()
        {
            DataTable studentTable = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("SelectStudent", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(com);

                    con.Open();
                    adapter.Fill(studentTable);
                    con.Close();
                }
            }

            return studentTable;
        }


        public List<Student> ConvertDataTableToList(DataTable dt)
        {
            List<Student> studentList = new List<Student>();

            foreach (DataRow dr in dt.Rows)
            {
                studentList.Add(
                    new Student
                    {
                        StudentID = Convert.ToInt32(dr["studentID"]),
                        Name = Convert.ToString(dr["name"]),
                        Age = Convert.ToInt32(dr["age"])
                    }
                );
            }

            return studentList;
        }





        public bool AddStudent(Student obj)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("InsertStudent", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@studentID", obj.StudentID);
                    com.Parameters.AddWithValue("@name", obj.Name);
                    com.Parameters.AddWithValue("@age", obj.Age);

                    con.Open();
                    int rowsAffected = com.ExecuteNonQuery();
                    con.Close();

                    return rowsAffected > 0;
                }
            }
        }

        // Update operation
        public bool UpdateStudent(Student obj)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("UpdateStudent", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@studentID", obj.StudentID);
                    com.Parameters.AddWithValue("@name", obj.Name);
                    com.Parameters.AddWithValue("@age", obj.Age);

                    con.Open();
                    int rowsAffected = com.ExecuteNonQuery();
                    con.Close();

                    return rowsAffected > 0;
                }
            }
        }

        // Delete operation
        public bool DeleteConfirm(int studentID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("DeleteStudent", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@studentID", studentID);


                    con.Open();
                    int rowsAffected = com.ExecuteNonQuery();

                    con.Close();

                    return rowsAffected > 0;
                }
            }
        }
    }
}