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

        private void button_hozzaad_Click(object sender, EventArgs e) //hozzáadás gomb kódja
        {
            //MySqlTransaction tr = null;
            //try
            //{
            //    tr = Program.connection.BeginTransaction();
            //    Program.command.Transaction = tr; 
            //    //-  vásárlás adatainak rögzítése
            //    Program.command.CommandText = "INSERT INTO `vasarlas` (`termekid`, `vasarloid`, `vasaroltdb`) VALUES (@vasarloid, @termekid, @vasaroltdb);";
            //    Program.command.Parameters.Clear();
            //    Program.command.Parameters.AddWithValue("@vasarloid", Program.UserId);
            //    Program.command.Parameters.AddWithValue("@termekid", textBox_termek.Text);
            //    Program.command.Parameters.AddWithValue("@vasarlodb", numericUpDown_db.Value);
            //    Program.command.ExecuteNonQuery();
            //    // a raktárkészlet aktuálizálása
            //    Program.command.CommandText = $"UPDATE `termek` SET `db`= db- {numericUpDown_db.Value} WHERE `termekid` = {textBox_termek.Text}";
            //    Program.command.ExecuteNonQuery();
            //    tr.Commit();
            //    textBox_termek.Text = "";
            //    
            //    numericUpDown_raktarkeszlet.Value = 0;
            //    numericUpDown_db.Value = 0;
            //    MessageBox.Show("Sikeres vásárlás");
            //}
            //catch (MySqlException ex)
            //{
            //    tr.Rollback();
            //    MessageBox.Show("Sikertelen vásárlás!");
            //}

            //vásárlás megerősítése
            string szoveg = $"Valóban meg akar vásárolni {numericUpDown_db} db {textBox_termek.Text} terméket {Convert.ToInt32(textBox_ara.Text)*numericUpDown_db.Value} Ft értékben?";
            if (MessageBox.Show(szoveg,"megerősítés",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) ;
            {

            }

            if (listBox_termek.SelectedIndex >= 0 && numericUpDown_db.Value > 0)
            {
                double osszertek = 0;
                Termek Rendeles = (Termek)listBox_termek.SelectedItem; 
                osszertek += Rendeles.Ar * (double)numericUpDown_db.Value;
                textBox_ara.Text = osszertek.ToString();
                listBox_termekek.Items.Add($"{listBox_termek.SelectedItem} {numericUpDown_db.Value}db. {textBox_ara.Text}Ft.");
                MessageBox.Show("sikeres vásárlás");
            }
            else
            {
                MessageBox.Show("Sikertelen vásárlás");
            }
        }

        private void listBox_termek_SelectedIndexChanged(object sender, EventArgs e) //megjelenített termékek kiválasztásii kódja
        {
            Termek Rendeles = (Termek)listBox_termek.SelectedItem;
            textBox_termek.Text = Rendeles.Termeknev;
            //numericUpDown_raktarkeszlet.Value = Rendeles.db;
            //numericUpDown_db.Maximum = Rendeles.db;
            //numericUpDown_db.Value = 1;
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Termek form_TermekUj = new Form_Termek("Új");
            form_TermekUj.ShowDialog(); //összekapcsolja a termékek formmal. 
        }
    }
}
