using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication34
{  

    public class EmployeeDAL
    {
        private string conStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public DataTable GetEmployees()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Emps", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertEmployee(int empno, string ename, string job, decimal sal, int deptno)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Emps VALUES(@empno, @ename, @job, @sal, @deptno)", con);
                cmd.Parameters.AddWithValue("@empno", empno);
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@sal", sal);
                cmd.Parameters.AddWithValue("@deptno", deptno);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(int empno, string ename, string job, decimal sal, int deptno)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Emps SET ename=@ename, job=@job, sal=@sal, deptno=@deptno WHERE empno=@empno", con);
                cmd.Parameters.AddWithValue("@empno", empno);
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@sal", sal);
                cmd.Parameters.AddWithValue("@deptno", deptno);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int empno)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Emps WHERE empno=@empno", con);
                cmd.Parameters.AddWithValue("@empno", empno);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}