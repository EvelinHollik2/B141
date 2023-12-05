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
    public partial class Form_TermekModositas : Form
    {
        string mod = null;
        public Form_TermekModositas(string mod)
        {
            InitializeComponent();
            this.mod = mod;

        }

        private void button_termekModositas_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "UPDATE `termek` SET `termeknev`=@termeknev,`db`=@db WHERE 1";
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

        private void Form_TermekModositas_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.mod);
            Program.form_Vasarlas.Betoltes();
        }

        private void listBox_termek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termek Rendeles = (Termek)listBox_termek.SelectedItem;
            textBox_termek.Text = Rendeles.Termeknev;
            
        }
    }
}
