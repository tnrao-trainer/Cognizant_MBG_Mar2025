
using Microsoft.Data.SqlClient;
using System.Data;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=DESKTOP-B3L5S5L\\SQLEXPRESS; Database=Apr2025Db; Integrated Security=true; TrustServerCertificate=True";
   
            string cmdText = "SELECT * FROM Students";

            SqlDataAdapter adapter = new SqlDataAdapter( cmdText, connStr  );
            DataSet ds = new DataSet();

            adapter.Fill( ds, "tblStudents" ); 
            
           foreach(DataRow row in  ds.Tables["tblStudents"].Rows ) 
            {
                Console.WriteLine($"{row["StudentID"].ToString()}, {row["Name"].ToString()}, {row["Age"].ToString()}, {row["Course"].ToString()} ");
            }  

            Console.ReadLine();
        }
    }
}
