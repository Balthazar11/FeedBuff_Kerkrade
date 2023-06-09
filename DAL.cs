
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FeedBuff_Kerkrade
{
    internal class DAL
    {
        private static string connectionString = "Data Source=.;Initial Catalog=Feedbuf;Integrated Security=True";

        public void LoadSubjectsIntoComboBox(ComboBox comboBox)
        {
            // Establish a connection to your database
            using (SqlConnection connection = new SqlConnection(connectionString))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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

            // Loop from 1 to 10 and add each integer value to the ComboBox
            for (int i = 1; i <= 10; i++)
            {
                comboBox.Items.Add(i);
            }
        }


        public void LoadGoalIntoComboBox(ComboBox comboBox)
        {
            // Establish a connection to your database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query to select the names of all users where Role_ID equals 2
                string query = "SELECT Goals_Desc FROM [Goal]";

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
        public void User_Insert_database(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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

                using (SqlConnection connection = new SqlConnection(connectionString))
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
        public List<string> FillListboxGoals(CheckedListBox checkedListBox)
        {
            List<string> selectedItems = new List<string>();
            string query = "SELECT Goal_ID, Weeknr, Goals_Desc, Feedback_ID, Subject_ID FROM Goal";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        checkedListBox.Items.Clear();
                        while (reader.Read())
                        {
                            string text = $"{reader["Goals_Desc"]}";
                            checkedListBox.Items.Add(text);
                        }
                    }
                }
            }
            return selectedItems;
        }

        public List<string> FillListBoxFeedback(CheckedListBox checkedListBox, int weekNr)
        {
            List<string> selectedItems = new List<string>();
            string query = "SELECT Feedback_ID, Feedback_Desc, Weeknr, Validated, [User].Name as UserName FROM Feedback " +
                           "JOIN [User] ON Feedback.User_ID = [User].User_ID " +
                           "WHERE Weeknr = @weekNr";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@weekNr", weekNr);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        checkedListBox.Items.Clear();
                        while (reader.Read())
                        {
                            string text = $"{reader["UserName"]} - {reader["Feedback_Desc"]}";
                            checkedListBox.Items.Add(text);
                        }
                    }
                }
            }
            return selectedItems;
        }



        public void Add_Feedback(string feedbackDesc, string weekString, bool validated, string userName)
        {
            // Extract week number from weekString
            int weekNr;
            if (Int32.TryParse(weekString, out weekNr))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO Feedback (FeedBack_desc, Weeknr, Validated, User_ID) " +
                                                                  "SELECT @FeedBack_Desc, @Weeknr, @Validated, [User].User_ID " +
                                                                  "FROM [User] WHERE [User].Name = @Name", connection))
                    {
                        command.Parameters.AddWithValue("@FeedBack_Desc", feedbackDesc);
                        command.Parameters.AddWithValue("@Weeknr", weekNr);
                        command.Parameters.AddWithValue("@Validated", validated);
                        command.Parameters.AddWithValue("@Name", userName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                throw new ArgumentException("Invalid week number format: " + weekString);
            }
        }

        public void Delete_feedback_database()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "USE Feedbuf ALTER TABLE Feedback " +
                                   "DROP COLUMN FeedBack_ID, " +
                                   "DROP COLUMN FeedBack_desc, " +
                                   "DROP COLUMN Weeknr, " +
                                   "DROP COLUMN Validated, " +
                                   "DROP COLUMN User_ID;";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        public void Alter_feedback_database(string new_data)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"USE YourDatabaseName; " +
                                   $"ALTER TABLE FeedbackTable " +
                                   $"ALTER COLUMN Feedback_desc {new_data};";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
    
        }

        public void subject_insert_database(Subject subject)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string sql = "INSERT INTO Subject (Subject_name) VALUES (@Subject_name)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Subject_name", subject.Subject_Name);

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

        public void Feedback_insert_database(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    string sql = "INSERT INTO Feedback (Feedback_desc,Weeknr,Validated,User_ID) VALUES (@Feedback_desc, @Weeknr, @Validated, @User_ID)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Feedback_desc", feedback.feedback);
                        command.Parameters.AddWithValue("@Weeknr",feedback.Weeknr );
                        command.Parameters.AddWithValue("@Validated",feedback.Validated );
                        command.Parameters.AddWithValue("@User_ID",feedback.User_ID);

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
    }
}