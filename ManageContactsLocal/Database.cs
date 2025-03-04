using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManageContactsLocal
{
    public static class Database
    {
        private static string connectionString = "Server=devweb2024.cis.strath.ac.uk;Database=xmb22143;User ID=xmb22143;Password="+getPassword()+";SslMode=none;";

        // Method to get the MySQL connection
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        // Example: A method to run a query and return results
        public static bool AuthenticateUser(string username, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM ManageContactsAccounts WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log it)
                    Console.WriteLine("Database connection error: " + ex.Message);
                    return false;
                }
            }
        }
        //TODO remove forupload
        private static string getPassword()
        {
            return "Obu7ooshaich";
        }
    }
     
}
