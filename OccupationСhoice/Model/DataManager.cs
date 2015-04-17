using System;
using System.Data.SQLite;
using System.Data;
using System.Windows;
using System.IO;
using System.Windows.Forms;

namespace OccupationСhoice
{
    public partial class DataManager
    {
        public DataManager(string dataBaseFile)
        {
            this.dataBaseFile = dataBaseFile;
        }

        private string dataBaseFile;

        public void CreateDataBase()
        {
            if (File.Exists(dataBaseFile))
            { return; }
            SQLiteConnection.CreateFile(this.dataBaseFile);
            SQLiteConnection connection = new SQLiteConnection();
            SQLiteConnectionStringBuilder conString = new SQLiteConnectionStringBuilder();
            conString.DataSource = this.dataBaseFile;
            connection.ConnectionString = conString.ToString();

            using (connection)
            {
                try
                { connection.Open(); }
                catch (Exception e)
                {
                    MessageBox.Show("Соединение не установлено. Причина: " + e.Message);
                    return;
                }

                SQLiteCommand createDataBase = connection.CreateCommand();
                createDataBase.CommandText = OccupationСhoice.Properties.Resources.DataBaseCreationScript;
                createDataBase.ExecuteNonQuery();
            }
        }

        private SQLiteConnection Connect()
        {
            SQLiteConnection connection = new SQLiteConnection();
            SQLiteConnectionStringBuilder cs = new SQLiteConnectionStringBuilder();
            cs.DataSource = dataBaseFile;
            connection.ConnectionString = cs.ToString();
            connection.Open();
            return connection;
        }

        public DataTable SelectQuery(string command)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection connect = Connect())
                {
                    SQLiteCommand select = connect.CreateCommand();
                    select.CommandText = command;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(select);
                    da.Fill(dt);
                }
            }
            catch { }
            return dt;
        }

        public bool MakeQuery(string command)
        {
            try
            {
                using (SQLiteConnection connect = Connect())
                {
                    SQLiteCommand make = connect.CreateCommand();
                    make.CommandText = command;
                    make.ExecuteNonQuery();
                }
            }
            catch { return false; }
            return true;
        }

        public string SelectScalarQuery(string command)
        {
            try
            {
                using (SQLiteConnection connect = Connect())
                {
                    SQLiteCommand select = connect.CreateCommand();
                    select.CommandText = command;
                    object value = select.ExecuteScalar();
                    if (value != null)
                        return value.ToString();
                }
            }
            catch { }
            return "";
        }
    }
}
