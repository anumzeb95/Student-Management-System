
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Student_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=CRIBV-DNET3; Database=studentDB;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("Select Name from std_info", connection);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                }
            }
        }
    }
}