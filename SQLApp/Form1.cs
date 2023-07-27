using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Data;

namespace SQLApp
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=D:\\VisualStudio\\repos\\SQLApp\\SQLApp\\NewDB.db";
        

        public Form1()
        {
            InitializeComponent();
            UpDB();
        }

        private void UpDB() 
        {   

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Users";
                using (SqliteCommand command = new SqliteCommand(sqlQuery, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String login = loginField.Text;
            String email = emailField.Text;
           

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "INSERT INTO Users(login, email) VALUES(@login, @email);";
                using (SqliteCommand command = new SqliteCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@email", email);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                connection.Close();
            }

            UpDB();

        }
    }
}