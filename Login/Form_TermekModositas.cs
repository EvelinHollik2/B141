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
            Program.command.CommandText = "UPDATE `termek` SET `termeknev`='[value-?]',`db`='[value-?]' WHERE 1";
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                Program.command.ExecuteNonQuery();
                MessageBox.Show("Sikeres rögzítés");
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
            Betoltes();
        }

        private void Betoltes()
        {
            listBox_termek.Items.Clear();
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                Program.command.CommandText = "UPDATE `termek` SET `termeknev`='?',`ar`='?',`db`='?' WHERE 1;";
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termek beolvasottTermek = new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db"));
                        listBox_termek.Items.Add(beolvasottTermek);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //hibakód
                Environment.Exit(0);
            }
        }

        private void listBox_termek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termek Rendeles = (Termek)listBox_termek.SelectedItem;
            textBox_termek.Text = Rendeles.Termeknev;
        }
    }
}
