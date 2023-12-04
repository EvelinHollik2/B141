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
    public partial class Form_FelhasznaloUj : Form
    {
        string mod = null;
        public Form_FelhasznaloUj(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Form_FelhasznaloUj_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.mod);
        }

        private void button_letrehozas_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "INSERT INTO `vasarlo` (`nev`, `jelszo`) VALUES ( '?', '?');";
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
    }
}
