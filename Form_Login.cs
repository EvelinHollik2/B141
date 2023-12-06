using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_OrarendNyilvantartas
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_bejelentkezes_Click(object sender, EventArgs e)
        {
            if (Program.db.login(textBox_FelhasznaloNev.Text, textBox_jelszo.Text)>=0)
            {
                Program.form_Orarend.Show();
            }
        }
    }
}
