using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Main
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        
        public string Server
        {
            get => server;
        }
       public string Database
        {
            get => database;
        }
        public string Uid
        {
            get => uid;
        }
        public string Password
        {
            get => password;
        }
        
        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "db4free.net";
            database = "dispensa";
            uid = "arturcruz";
            password = "Riomaior3";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(string tableName, string[] fields, string[] values)
        {
            string query = $"INSERT INTO {database}.{tableName.Trim()} ({string.Join(",", fields)}) VALUES({string.Join(",", values)})";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void Update(string tableName, string change,string condition = null)
        {
            string query = $"UPDATE {database}.{tableName} SET {change}";

            if(!string.IsNullOrEmpty(condition.Trim()))
                query += $" WHERE {condition.Trim()}";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
        public void Update(string tableName, string[] changes,string condition = null)
        {
            string query = $"UPDATE {database}.{tableName} SET ";

            foreach(string change in changes)
                query += tableName + "." + change.Trim() + ", ";
            query = query.TrimEnd(' ').Trim(',');

            if(!string.IsNullOrEmpty(condition.Trim()))
                query += $" WHERE {condition.Trim()}";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Delete(string tableName, string condition = null)
        {
            string query = $"DELETE FROM {database}.{tableName}";
            
            if(!string.IsNullOrEmpty(condition.Trim()))
                query += $" WHERE {condition.Trim()}";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<string>[] Select(string tableName, string[] tableFields,string condition = null, string order = null)
        {
            string query = $"SELECT ";
            if (tableFields[0] != "*")
            {
                foreach (string tableField in tableFields)
                    query += $"{database}.{tableName}.{tableField.Trim()}, ";
                query = query.TrimEnd(',', ' ');
            }
            else
                query += tableFields[0];


            query += $" FROM {database}.{tableName}";

            if (!string.IsNullOrEmpty(condition))
                query += $" WHERE {condition.Trim()}";

            if (!string.IsNullOrEmpty(order))
                query += $" ORDER BY {order.Trim()}";

            //Create a list to store the result
            List<string>[] list = new List<string>[tableFields.Length];
            for(int i = 0; i<tableFields.Length; i++)
                list[i] = new List<string>() ;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    for (int i = 0; i < tableFields.Length; i++)
                        list[i].Add(dataReader[tableFields[i].Trim()] + "");
                                 }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public int Count(string tableName, string field, string condition, string order)
        {
            string query = $"SELECT Count({database}.{tableName}.{field}) FROM {database}.{tableName}";
            int Count = -1;

            if (!string.IsNullOrEmpty(condition))
                query += $" WHERE {condition.Trim()}";


            if (!string.IsNullOrEmpty(order))
                query += $" ORDER BY {order.Trim()}";


            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public string Max(string tableName, string field, string condition = null, string order = null)
        {
            string query = $"SELECT MAX({database}.{tableName}.{field}) FROM {database}.{tableName}";

            if (!string.IsNullOrEmpty(condition))
                query += $" WHERE {condition.Trim()}";

            if (!string.IsNullOrEmpty(order))
                query += $" ORDER BY {order.Trim()}";

            dynamic max = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                
                max = cmd.ExecuteScalar() + "";

                //close Connection
                this.CloseConnection();

                return max;
            }
            else
            {
                return max;
            }
        }


        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error , unable to backup!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error , unable to restore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
