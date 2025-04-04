using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ConsoleApp9
{  
    class StudentManagement
    {
        static string connStr = "Server=DESKTOP-B3L5S5L\\SQLEXPRESS; Database=Apr2025Db; Integrated Security=true; TrustServerCertificate=True";

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n*** Student Management System ****");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5) {
                    break;
                }

                switch (choice)
                {
                    case 1: AddStudent(); break;
                    case 2: ViewStudents(); break;
                    case 3: UpdateStudent(); break;
                    case 4: DeleteStudent(); break;                   
                    default: Console.WriteLine("Invalid option!"); break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string cmdText = "INSERT INTO Students (Name, Age, Course) VALUES (@Name, @Age, @Course)";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.ExecuteNonQuery();
            };

            Console.WriteLine("Student Added Successfully!");
        }

        static void ViewStudents()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string cmdText = "SELECT * FROM Students";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["StudentID"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, Course: {reader["Course"]}");
                }
            }
        }

        static void UpdateStudent()
        {
            Console.Write("Enter Student ID to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter New Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string cmdText = "UPDATE Students SET Age = @Age WHERE StudentID = @ID";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Student Updated Successfully!");
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student ID to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string cmdText = "DELETE FROM Students WHERE StudentID = @ID";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Student Deleted Successfully!");
        }
    }



}
