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
