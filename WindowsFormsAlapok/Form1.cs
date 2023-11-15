using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            Adatbetoltes(openFileDialog1.FileName);
        }

        private void button_TeruletekAtlaga_Click(object sender, EventArgs e)
        {
            atlagszamitas2();

        }

        private void atlagszamitas2()
        {
            double atlag = listBox_Orszagoklista.Items.Cast<Orszag>().ToList().Average(a => a.Terulet);
            MessageBox.Show($"Az országok átlaga: {atlag.ToString("#,##0.00")}", "Az országok átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void atlagszamitas()
        {
            double atlag = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                atlag += item.Terulet;
            }
            atlag = atlag / listBox_Orszagoklista.Items.Count;
            MessageBox.Show($"Az országok átlaga: {atlag.ToString("#,##0.00")}", "Az országok átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_MinMax.SelectedIndex = 0;
            string kiindulasiFajl = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "orszagok.csv";
            if (File.Exists(kiindulasiFajl))
            {
                Adatbetoltes(kiindulasiFajl);
            }
        }

        private void Adatbetoltes(string file)
        {
            openFileDialog1.Filter = "vesszővel tagolt csv|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfájl neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "orszagok.csv";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Orszagoklista.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }
            }
        }

        private void button_Megszamolas_Click(object sender, EventArgs e)
        {
            if (radioButton_LegfeljebbSzazEzer.Checked)
            {
                szamolLegfeljebbSzazezer();
            } else
            {
                szamolSzazezerFelett();
            }
        }

        private void szamolSzazezerFelett()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet >= 100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"100.000 feletti= {db}", "100.000 feletti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void szamolLegfeljebbSzazezer()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet<=100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"Maximum 100.000= {db}", "Maximum 100.000", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Kiiras_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "valami szöveg a felhasználónak|*.txt";
            saveFileDialog.InitialDirectory=Environment.CurrentDirectory;
            saveFileDialog.FileName = "eredmeny.txt";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                string eredmenyFajl = saveFileDialog.FileName;
                textBox_EredmenyFajlNeve.Text = Path.GetFileName(eredmenyFajl);
                try
                {
                    using (StreamWriter sw = new StreamWriter(eredmenyFajl))
                    {
                        sw.WriteLine("Ez az eredmény");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("valami nem ok!" + Environment.NewLine + ex.Message);

                    
                }
            }
        }

        private void button_Maximum_Minimum_Valasztas_Click(object sender, EventArgs e)
        {
            if (comboBox_MinMax.SelectedIndex == 0)
            {
                Orszag keresettOszag = null;
                double keresettErtek = ((Orszag)listBox_Orszagoklista.Items[0]).Terulet;
                foreach (Orszag item in listBox_Orszagoklista.Items)
                {
                    if (keresettErtek > item.Terulet)
                    {
                        keresettErtek = item.Terulet;
                        keresettOszag = item;
                    }
                }
                MessageBox.Show($"Minimum {keresettOszag.OrszagNev} terület: {keresettOszag.Terulet}");
            }
        }

        private void szinvaltoztatas(object sender, EventArgs e)
        {
            textBox_KeresettOrszag.BackColor = Color.LightPink;
        }

        private void textBox_KeresettOrszag_MouseLeave(object sender, EventArgs e)
        {
            textBox_KeresettOrszag.BackColor = DefaultBackColor;
        }
    }
}
