using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp_OrarendNyilvantartas
{
    internal static class Program
    {
        public static Form_Login form_Login = null;
        public static Form_Orarend form_Orarend = null;
        public static MySqlConnection connection = null;
        public static MySqlCommand command = null;
        public static int userId;
        static void Main()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Login = new Form_Login();
            form_Orarend = new Form_Orarend();

            Application.Run(form_Login);
        }
    }
}
