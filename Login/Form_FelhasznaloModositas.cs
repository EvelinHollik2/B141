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
    public partial class Form_FelhasznaloModositas : Form
    {
        string mod = null;
        public Form_FelhasznaloModositas(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Form_FelhasznaloModositas_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.mod);
            Program.form_Vasarlas.Betoltes();
        }

        private void button_termekModositas_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "UPDATE `vasarlo` SET `nev` = @nev, `jelszo` = @jelszo WHERE `vasarlo`.`vasarloid` = @vasarloid;";
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

        private void listBox_felhasznalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Felhasznalo Rendeles = (Felhasznalo)listBox_felhasznalo.SelectedItem;
            textBox_kivalaszottFrlhasznalo.Text = Rendeles.Nev;
        }
    }
}
