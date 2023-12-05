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
    public partial class Form_Termek : Form
    {
        string mod = null;
        public Form_Termek(string mod) //paramérterezés 
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Form_Termek_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.mod);
            
        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "INSERT INTO `termek`(`termekid`, `termeknev`, `ar`, `db`) VALUES('" + "" + "','" + textBox_hozzaad_nev.Text + "','" + numericUpDown_hozzaad_ar.Value + "','" + numericUpDown_hozzaad_db.Value + "')";
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés");
                Program.form_Vasarlas.Betoltes();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
