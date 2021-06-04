using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;
using NFS.Properties;
using NLog;

namespace NFS
{
    class DB
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private bool isConnectionOpen = false;
        //private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=nfs");
        private MySqlConnection connection = new MySqlConnection($"server={Settings.Default.server};port={Settings.Default.port};username={Settings.Default.username};password={Settings.Default.password};database={Settings.Default.database}");
        
        public void OpenConnection()
        {
            try
            {
                logger.Info("MYSQL open connection is successful;");
                connection.Open();
                isConnectionOpen = true;
            }
            catch (Exception ex)
            {
                isConnectionOpen = false;
                logger.Fatal($"MYSQL CONNECT ERROR : {ex.Message};");
                MessageBox.Show("MYSQL CONNECT ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                logger.Info("MYSQL close connection is successful;");
                connection.Close();
                isConnectionOpen = false;
            }
        }

        public MySqlConnection GetConnection()
        {
            logger.Info("GetConnection is successful;");
            return connection;
        }

        public void SetPassword(string user, string pass)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `pass` = @password WHERE `users`.`login` = @login;", GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;

            OpenConnection();
            if (isConnectionOpen)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    logger.Info("Password change is successful;");
                    MessageBox.Show(@"Password change has been completed");
                }
            }
            else
            {
                logger.Warn("Password change is unsuccessful;");
                MessageBox.Show(@"Password change can't be completed. Please try again later!");
            }

            CloseConnection();
        }
        public void SetEmail(string oldEmail, string newEmail)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `login` = @loginNew WHERE `users`.`login` = @loginOld;", GetConnection());

            command.Parameters.Add("@loginNew", MySqlDbType.VarChar).Value = newEmail;
            command.Parameters.Add("@loginOld", MySqlDbType.VarChar).Value = oldEmail;
            
            OpenConnection();
            if (isConnectionOpen)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    logger.Info("Email change is successful;");

                    MessageBox.Show(@"Email change has been completed");
                }
            }
            else
            {
                logger.Warn("Email change is unsuccessful;");
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
            if (isConnectionOpen)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    logger.Info("Name change is successful;");
                    MessageBox.Show(@"Name change has been completed");
                }
            }
            else
            {
                logger.Warn("Name change is unsuccessful;");
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
            if (isConnectionOpen)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    logger.Info("Registration is successful;");
                    MessageBox.Show(@"Registration has been completed");
                }
            }
            else
            {
                logger.Warn("Registration is unsuccessful;");
                MessageBox.Show(@"Registration can't be completed. Please try again later!");
            }

            CloseConnection();
        }
        public void DeleteUser(string login)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `users`.`login` = @login;", GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            OpenConnection();
            if (isConnectionOpen)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    logger.Info("User account deleting is successful;");
                    MessageBox.Show(@"User account delete has been completed");
                }
            }
            else
            {
                logger.Warn("User account deleting is unsuccessful;");
                MessageBox.Show(@"User account delete can't be completed. Please try again later!");
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
                logger.Warn("Loging is unsuccessful;");
                CloseConnection();
                return -1;
            }

            if (table.Rows.Count > 0)
            {
                logger.Info("Loging is successful;");
                return 1;
            }
            else
            {
                logger.Warn("Loging is unsuccessful;");
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
                logger.Warn("Users checking failed!");
                CloseConnection();
                return -1;
            }
            
            if (table.Rows.Count > 0)
            {
                logger.Info("User is exist;");
                return 1;
            }
            else
            {
                logger.Info("User isn't exist;");
                return 0;
            }
        }
        public void SetScore(string login, int score)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `record`=IF(`record`<@score,@score,`record`)WHERE `users`.`login` = @login;", GetConnection());

            command.Parameters.Add("@score", MySqlDbType.VarChar).Value = score;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            OpenConnection();
            if (isConnectionOpen)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    logger.Info("Set new score is successful;");
                }
            }
            else
            {
                logger.Warn("Set new score is unsuccessful;");
                MessageBox.Show(@"Set new score can't be completed. Please try again later!");
            }

            CloseConnection();
        }
        public int GetCountOfGames(string login)
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL;", GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            OpenConnection();
            if (isConnectionOpen)
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
                CloseConnection();
            }
            else
            {
                logger.Warn("GetCountOfGames is unsuccessful;");
                CloseConnection();
            }

            if (table.Rows.Count > 0)
            {
                logger.Info($"GetCountOfGames is successful - {table.Rows[0][5]};");
                return (int)table.Rows[0][5];
            }
            else
            {
                logger.Warn("GetCountOfGames is unsuccessful;");
                return -1;
            }
        }
        public void SetCountOfGames(string login)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `countOfGames` = @countOfGames WHERE `users`.`login` = @login;", GetConnection());
            int countOfGames = GetCountOfGames(login) + 1;
            command.Parameters.Add("@countOfGames", MySqlDbType.VarChar).Value = countOfGames;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            OpenConnection();
            if (isConnectionOpen)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    logger.Info($"Set new count Of Games is successful - {countOfGames};");
                }
            }
            else
            {
                logger.Warn("Set new count Of Games is unsuccessful;");
                MessageBox.Show(@"Set new new count Of Games can't be completed. Please try again later!");
            }

            CloseConnection();
        }
        public DataTable GetData()
        {
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` ORDER BY id", GetConnection());
            
            OpenConnection();
            if (isConnectionOpen)
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
                CloseConnection();
            }
            else
            {
                logger.Warn("GetData is unsuccessful;");
                CloseConnection();
               
            }
            if (table.Rows.Count > 0)
            {
                logger.Info("GetData is successful;");
                return table;
            }
            else
            {
                logger.Warn("GetData is unsuccessful;");
                return table;
            }
        }
    }
}
