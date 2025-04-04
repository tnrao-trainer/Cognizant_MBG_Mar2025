using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ConsoleApp9
{
    class StudentManagementSystem
    {
        // Change this connection string as per your database configuration
        static string connStr =  "Server=DESKTOP-B3L5S5L\\SQLEXPRESS; Database=Apr2025Db; Integrated Security=true; TrustServerCertificate=True";

        static DataSet studentDataSet = new DataSet();
        static SqlDataAdapter dataAdapter;

        static void Main()
        {
            LoadData(); // Load data initially

            while (true)
            {
                Console.WriteLine("\nStudent Management System (Disconnected Model)");
                Console.WriteLine("1. Add a New Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Save Changes to Database");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        SaveChanges();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }
            }
        }

        static void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM Students";
                dataAdapter = new SqlDataAdapter(query, con); 
               
                studentDataSet.Clear(); // Clear previous data if any
                dataAdapter.Fill(studentDataSet, "Students"); // Fill dataset
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            DataRow newRow = studentDataSet.Tables["Students"].NewRow();
            newRow["Name"] = name;
            newRow["Age"] = age;
            newRow["Course"] = course;
            studentDataSet.Tables["Students"].Rows.Add(newRow);

            Console.WriteLine("Student Added Locally. Save changes to update database.");
        }

        static void ViewStudents()
        {
            Console.WriteLine("\nList of Students:");
            Console.WriteLine("------------------------------------------------------");
            foreach (DataRow row in studentDataSet.Tables["Students"].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    Console.WriteLine($"ID: {row["StudentID"]}, Name: {row["Name"]}, Age: {row["Age"]}, Course: {row["Course"]}");
                }
                else
                {
                    Console.WriteLine("This row marked as deleted");
                }
            }
            Console.WriteLine("------------------------------------------------------");
        }

        static void UpdateStudent()
        {
            Console.Write("Enter Student ID to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow[] rows = studentDataSet.Tables["Students"].Select($"StudentID = {id}");
            if (rows.Length > 0)
            {
                Console.Write("Enter New Age: ");
                int newAge = Convert.ToInt32(Console.ReadLine());

                rows[0]["Age"] = newAge; // Update in memory

                Console.WriteLine("Student Updated Locally. Save changes to update database.");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student ID to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow[] rows = studentDataSet.Tables["Students"].Select($"StudentID = {id}");
            if (rows.Length > 0)
            {
                rows[0].Delete(); // Mark row for deletion in DataSet

                Console.WriteLine("Student Marked for Deletion. Save changes to update database.");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void SaveChanges()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM Students";
                dataAdapter = new SqlDataAdapter(query, con);

                // CommandBuilder automatically generates INSERT, UPDATE, DELETE commands
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Update(studentDataSet, "Students"); // Update database
            }
            Console.WriteLine("Changes Saved to Database!");
            LoadData(); // Reload data after saving
        }
    }


}
