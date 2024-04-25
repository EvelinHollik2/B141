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
        public static int userId;
        public static Database db = new Database();
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Login = new Form_Login();
            form_Orarend = new Form_Orarend();

            Application.Run(form_Login);
        }
    }
}
