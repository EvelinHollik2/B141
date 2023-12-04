using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Zlib;
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
    public partial class Form_TermekTorles : Form
    {
        string mod = null;
        public Form_TermekTorles(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Form_TermekTorles_Load(object sender, EventArgs e)
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
                Program.command.CommandText = "SELECT `termekid`, `termeknev`, `ar`, `db` FROM `termek` WHERE 1;";
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
            textBox_kivalasztottTermek.Text = Rendeles.Termeknev;
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "DELETE FROM `termek` WHERE `termekid` = ?;";
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
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
