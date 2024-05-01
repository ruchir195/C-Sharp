using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeContext
    {

        private string connectionString = "Server=DESKTOP-4C2CAEV\\SQLEXPRESS; database=AdoPractice; Integrated Security=SSPI";


        public DataTable SelectEmployee()
        {
            DataTable employeeTable = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("selectEmployee", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(com);

                    con.Open();
                    adapter.Fill(employeeTable);
                    con.Close();
                }
            }

            return employeeTable;
        }


        public List<Employee> ConvertDataTableToList(DataTable dt)
        {
            List<Employee> empList = new List<Employee>();

            foreach (DataRow dr in dt.Rows)
            {
                empList.Add(
                    new Employee
                    {
                        id = Convert.ToInt32(dr["id"]),
                        name = Convert.ToString(dr["name"]),
                        age = Convert.ToInt32(dr["age"]),
                        city = Convert.ToString(dr["city"]),
                        gender = Convert.ToString(dr["gender"]),
                        department = Convert.ToString(dr["department"]),
                    }
                );
            }

            return empList;
        }






        public bool AddEmployee(Employee obj)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("addEmployee", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", obj.id);
                    com.Parameters.AddWithValue("@name", obj.name);
                    com.Parameters.AddWithValue("@age", obj.age);
                    com.Parameters.AddWithValue("@city", obj.city);
                    com.Parameters.AddWithValue("@gender", obj.gender);
                    com.Parameters.AddWithValue("@department", obj.department);

                    con.Open();
                    int rowsAffected = com.ExecuteNonQuery();
                    con.Close();

                    return rowsAffected > 0;
                }
            }
        }

        // Update operation
        public bool UpdateEmployee(Employee obj)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("updateEmployee", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", obj.id);
                    com.Parameters.AddWithValue("@name", obj.name);
                    com.Parameters.AddWithValue("@age", obj.age);
                    com.Parameters.AddWithValue("@city", obj.city);
                    com.Parameters.AddWithValue("@gender", obj.gender);
                    com.Parameters.AddWithValue("@department", obj.department);

                    con.Open();
                    int rowsAffected = com.ExecuteNonQuery();
                    con.Close();

                    return rowsAffected > 0;
                }
            }
        }

        // Delete operation
        public bool DeleteConfirm(int employeeId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand("deleteEmployee", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", employeeId);


                    con.Open();
                    int rowsAffected = com.ExecuteNonQuery();

                    con.Close();

                    return rowsAffected > 0;
                }
            }
        }

    }
}
