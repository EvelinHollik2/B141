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
            Program.command.CommandText = "SELECT `jelszo`,`tanarid` FROM `tanarok` WHERE `tanarnev` = @nev;";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@nev", textBox_FelhasznaloNev.Text);
            if (Program.connection.State != ConnectionState.Open)
            {
                Program.connection.Open();

            }
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                Program.userId = reader.GetInt32("tanarid");
                reader.Close();
                if (taroltJelszo.Equals(textBox_jelszo.Text))
                {
                    reader.Close();
                    Program.form_Orarend.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("NOT GOOD!");
                }
            }
        }
    }
}
