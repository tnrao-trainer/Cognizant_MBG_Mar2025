
using Microsoft.Data.SqlClient;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=DESKTOP-B3L5S5L\\SQLEXPRESS; Database=Apr2025Db; Integrated Security=true; TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connStr);


            string cmdText = "SELECT Count(*) FROM Students";
            SqlCommand cmd = new SqlCommand(cmdText, con);  


            con.Open();
            int n = (int) cmd.ExecuteScalar();

            Console.WriteLine("Connected to SQL Server");
            Console.WriteLine("No. of Students in Database : " + n);

            con.Close();

            Console.ReadLine();
        }
    }
}
