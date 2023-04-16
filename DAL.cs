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
        string connectionString = "Data Source=.;Initial Catalog=Feedbuf;Integrated Security=True";
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
    }
}
