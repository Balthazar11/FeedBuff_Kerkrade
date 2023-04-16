using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace FeedBuff_Kerkrade
{
    public class DAL
    {
        string connectionstring = "Data Source=.;Initial Catalog=Feedbuf;Integrated Security=True";
        public void User_Insert_database(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO [User] (Name, Password) VALUES (@Name, @Password)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Password", user.Password);

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

        public bool User_Check_database(User user)
        {
            try
            {
                // lijsten voor de naam en wachtwoord uit de database
                List<string> usernames = new List<string>();
                List<string> passwords = new List<string>();

                string query = "SELECT Name, Password FROM [User]";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usernames.Add(reader.GetString(0));
                                passwords.Add(reader.GetString(1));
                            }
                        }
                    }
                }

                // Checken of de name met het gebruikte password overeenkomt
                for (int i = 0; i < usernames.Count; i++)
                {
                    if (user.Name == usernames[i] && user.Password == passwords[i])
                    {
                        return true;
                    }
                }
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
                return false;
            }
        }

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
    }
}
