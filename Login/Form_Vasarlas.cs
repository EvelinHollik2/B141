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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class Form_Vasarlas : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public Form_Vasarlas()
        {
            InitializeComponent();
        }

        private void Form_Vasarlas_Load(object sender, EventArgs e)
        {
            Betoltes();
        }

        private void Betoltes()
        {
            listBox_termek.Items.Clear();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = "SELECT `termekid`, `termeknev`, `ar`, `db` FROM `termek` WHERE 1;";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termek beolvasottTermek = new Termek(dr.GetInt32("termekazon"), dr.GetString("nev"), dr.GetInt32("ar"), dr.GetInt32("db"));
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

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            if (listBox_termek.SelectedIndex >= 0 && numericUpDown_db.Value > 0)
            {
                double osszertek = 0;
                Termek Rendeles = (Termek)listBox_termek.SelectedItem;
                osszertek += Rendeles.ar * (double)numericUpDown_db.Value;
                textBox_ara.Text = osszertek.ToString();
                listBox_termekek.Items.Add($"{listBox_termek.SelectedItem} {numericUpDown_db.Value}db.");
            }
        }

        private void listBox_termek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termek Rendeles = (Termek)listBox_termek.SelectedItem;
            textBox_termek.Text = Rendeles.Termek;
        }
    }
}
