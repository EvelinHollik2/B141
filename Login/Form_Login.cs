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

namespace Login
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        public void button_belepes_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "SELECT vasarlo.jelszo FROM `vasarlo` WHERE vasarlo.nev = @nev;";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                if (taroltJelszo.Equals(textBox_jelszo.Text))
                {
                    //megadott és  tárolt jelszó megegyezik
                    Program.form_Vasarlas.Show(); //megnyitjuk a vásárlás felületet
                    this.Hide(); //bezárjuk a logint
                }
                else
                {
                    MessageBox.Show("nem jou, not good");
                }
            }
        }
    }
}
