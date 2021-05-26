
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace NFS
{
    class DB
    {
        private bool isConnectionOpen = false;
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=nfs");

        public void OpenConnection()
        {
            try
            {
                connection.Open();
                isConnectionOpen = false;
            }
            catch (Exception ex)
            {
                isConnectionOpen = false;
                MessageBox.Show("SQLITE CONNECT ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                isConnectionOpen = false;
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void SetPassword(string user, string pass)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `pass` = @password WHERE `users`.`login` = @login;", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;

            db.OpenConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(@"Password change has been completed");
            }
            else
            {
                MessageBox.Show(@"Password change can't be completed. Please try again later!");
            }


            db.CloseConnection();
        }
        public void SetEmail(string oldEmail, string newEmail)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `login` = @loginNew WHERE `users`.`login` = @loginOld;", GetConnection());

            command.Parameters.Add("@loginNew", MySqlDbType.VarChar).Value = newEmail;
            command.Parameters.Add("@loginOld", MySqlDbType.VarChar).Value = oldEmail;

            OpenConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(@"Email change has been completed");
            }
            else
            {
                MessageBox.Show(@"Email change can't be completed. Please try again later!");
            }


            CloseConnection();
        }
        public void SetName(string email, string newName)
        {
            
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `name` = @nameNew WHERE `users`.`login` = @login;", GetConnection());

            command.Parameters.Add("@nameNew", MySqlDbType.VarChar).Value = newName;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = email;

            OpenConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(@"Name change has been completed");
            }
            else
            {
                MessageBox.Show(@"Name change can't be completed. Please try again later!");
            }


            CloseConnection();
        }
        public void AddUser(string emailField, string passField, string userNameField)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`) VALUES (@login, @password, @name)", GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = emailField;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField;

            OpenConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(@"Registration has been completed");
            }
            else
            {
                MessageBox.Show(@"Registration can't be completed. Please try again later!");
            }

            CloseConnection();
        }

        public int IsLogin(string emailField, string passField)
        {

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = emailField;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField;
            OpenConnection();
            if (isConnectionOpen)
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
                CloseConnection();
            }
            else
            {
                CloseConnection();
                return -1;
            }

            if (table.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int IsUserExist(string emailField)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = emailField;


            OpenConnection();
            if (isConnectionOpen)
            {
                adapter.SelectCommand = command;
                adapter.Fill(table); 
                CloseConnection();
            }
            else
            {
                CloseConnection();
                return -1;
            }
            
            if (table.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
