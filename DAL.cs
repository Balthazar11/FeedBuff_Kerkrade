using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{

    internal class DAL
    {
        string connectionstring = "Data Source=.;Initial Catalog=Feedbuf;Integrated Security=True";

        public void LoadSubjectsIntoComboBox(ComboBox comboBox)
        {
            // Establish a connection to your database
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to select the Subject_name column from the Subject table
                string query = "SELECT Subject_name FROM Subject";

                // Create a SqlCommand object to execute the SQL query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a SqlDataReader object to read the results of the SQL query
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing items in the ComboBox
                        comboBox.Items.Clear();

                        // Loop through each record in the SqlDataReader and add the Subject_name value to the ComboBox
                        while (reader.Read())
                        {
                            string subjectName = reader.GetString(0);
                            comboBox.Items.Add(subjectName);
                        }
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        public void LoadTeachersIntoCombobox(ComboBox comboBox)
        {
            // Establish a connection to your database
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to select the names of all users where Role_ID equals 2
                string query = "SELECT Name FROM [User] WHERE Role_ID = 2";

                // Create a SqlCommand object to execute the SQL query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a SqlDataReader object to read the results of the SQL query
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing items in the ComboBox
                        comboBox.Items.Clear();
                        comboBox.Items.Add("");

                        // Loop through each record in the SqlDataReader and add the name value to the ComboBox
                        while (reader.Read())
                        {
                            string userName = reader.GetString(0);
                            comboBox.Items.Add(userName);
                        }
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        public void LoadWeekIntoComboBox(ComboBox comboBox)
        {
            // Clear the existing items in the ComboBox
            comboBox.Items.Clear();
            comboBox.Items.Add("");

            // Loop from 1 to 10 and add each integer value with "Week" string to the ComboBox
            for (int i = 1; i <= 10; i++)
            {
                comboBox.Items.Add("Week " + i);
            }
        }
        public void User_Insert_database(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string sql = "INSERT INTO [User] (Name, Password, Role_ID) VALUES (@Name, @Password, @Role_ID)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Role_ID", 3);

                        // Open de databaseverbinding en voer de SQL-query 
                        int result = command.ExecuteNonQuery();

                        // Controleer het resultaat
                        if (result > 0)
                        {
                            MessageBox.Show("Record inserted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Record not inserted");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }
        public bool User_Check_database(User user, out int userID, out string userRole)
        {
            try
            {
                // Initialize variables for the user ID and role
                userID = 0;
                userRole = "";

                string query = @"SELECT u.User_ID, r.Rol_Name
                         FROM [User] u
                         INNER JOIN [Role] r ON u.Role_ID = r.Role_ID
                         WHERE u.Name = @name AND u.Password = @password";

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", user.Name);
                        command.Parameters.AddWithValue("@password", user.Password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userID = reader.GetInt32(0);
                                userRole = reader.GetString(1);
                                return true;
                            }
                        }
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
                userID = 0;
                userRole = "";
                return false;
            }
        }




    }
}
