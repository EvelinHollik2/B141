using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_OrarendNyilvantartas
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Database()
        {
            MySqlConnectionStringBuilder conn = new MySqlConnectionStringBuilder();
            conn.Server = "localhost";
            conn.UserID = "root";
            conn.Password = "";
            conn.Database = "orarend";
            conn.CharacterSet = "utf8";
            connection = new MySqlConnection(conn.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                nyit();

                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public List<Orarend> getNapiOrarend(string hetnapja)
        {
            nyit();
            List<Orarend> orarends = new List<Orarend>();
            command.CommandText = "SELECT `oraid`,`tantargy`,`sorszam`,`hetnapja` FROM `orak` WHERE `hetnapja` = @hetnapja;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@hetnapja", hetnapja);
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Orarend beolvasottTermek = new Orarend(dr.GetInt32("oraid"), dr.GetString("tantargy"), dr.GetInt32("sorszam"), dr.GetString("hetnapja"));
                    orarends.Add(beolvasottTermek);
                }
            }
            zar();
            return orarends;
        }
        public int login(string tanarnev, string jelszo)
        {
            int tanarid = -1;
            nyit();
            command.CommandText = "SELECT `jelszo`, tanarid FROM `tanarok` WHERE `tanarnev` = @nev;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", tanarnev);
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                string taroltJelszo = dr.GetString("jelszo");
                if (taroltJelszo.Equals(jelszo))
                {
                    tanarid = dr.GetInt32("tanarid");
                }
            }
            zar();
            return tanarid;

        }
    }
}
