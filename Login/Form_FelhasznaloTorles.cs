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
    public partial class Form_FelhasznaloTorles : Form
    {
        string mod = null;
        public Form_FelhasznaloTorles(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Form_FelhasznaloTorles_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.mod);
            Program.form_Vasarlas.Betoltes();
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "DELETE FROM vasarlo WHERE `vasarlo`.`vasarloid` = @vasarloid";
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                Program.command.ExecuteNonQuery();
                if (MessageBox.Show("Valóban ki akarja törölni?", "törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //System.Windows.Forms.Application.Exit();
                    //Environment.Exit(0);
                    System.Windows.Forms.Application.ExitThread();
                    MessageBox.Show("Sikeres Törlés");
                    Program.form_Vasarlas.Betoltes();
                }

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
            textBox_kivalasztottFelhasznalo.Text = Rendeles.Nev;
        }
    }
}
