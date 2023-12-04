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

        private void textBox_hozzaad_nev_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            //if (textBox_hozzaad_nev.Text = 0 && numericUpDown_hozzaad_db.Value >= 0)
            //{
            //    double osszertek = 0;
            //    Termek Rendeles = (Termek)textBox_hozzaad_nev.SelectedItem;
            //    osszertek += Rendeles.Ar * (double)numericUpDown_db.Value;
            //    textBox_ara.Text = osszertek.ToString();
            //    listBox_termekek.Items.Add($"{listBox_termek.SelectedItem} {numericUpDown_db.Value}db. {textBox_ara.Text}Ft.");
            //    MessageBox.Show("sikeres vásárlás");
            //}
            //else
            //{
            //    MessageBox.Show("Sikertelen vásárlás");
            //}
        }
    }
}
