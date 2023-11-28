using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    internal static class Program
    {
        // a többi osztályban (Form-ok) is használható
        public static Form_Login form_Login = null;
        public static Form_Vasarlas form_Vasarlas = null;
        public static MySqlConnection connection = null;
        public static MySqlCommand command = null;
        static void Main()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "vasarlas";
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
            form_Vasarlas = new Form_Vasarlas();
            Application.Run(form_Login);
        }
    }
}
