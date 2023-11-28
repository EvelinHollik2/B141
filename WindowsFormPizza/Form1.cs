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

namespace WindowsFormPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string kiindulasiFajl = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "pizza.csv";
            if (File.Exists(kiindulasiFajl))
            {
                Adatbetoltes(kiindulasiFajl);
            }
        }

        private void Adatbetoltes(string file)
        {
            listBox_pizza.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_pizza.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_atlag_Click(object sender, EventArgs e)
        {
            atlagszamitas();
        }

        private void atlagszamitas()
        {
            double atlag = listBox_pizza.Items.Cast<Pizza>().ToList().Average(a => a.Ar);
            MessageBox.Show($"A pizzák átlaga: {atlag.ToString("#,##0.0 Ft")}", "A pizzák átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            if (listBox_pizza.SelectedIndex >= 0 && numericUpDown_mennyiseg.Value > 0)
            {
                double osszertek = 0;
                Pizza Rendeles = (Pizza)listBox_pizza.SelectedItem;
                osszertek += Rendeles.Ar * (double)numericUpDown_mennyiseg.Value;
                textBox_ara.Text = osszertek.ToString();
                listBox_kosar.Items.Add($"{listBox_pizza.SelectedItem} {numericUpDown_mennyiseg.Value}db.");
            }
        }

        private void listBox_pizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza Rendeles = (Pizza)listBox_pizza.SelectedItem;
            textBox_rendeles.Text = Rendeles.PizzaNev;
        }

        private void button_rendeles_Click(object sender, EventArgs e)
        {
            if (radioButton_kezpenz.Checked && listBox_kosar.Items.Count >= 1 || radioButton_bankkartya.Checked && listBox_kosar.Items.Count >= 1)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Szöveges fájl|*.txt";
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog.FileName = "rendeles.txt";
                string rendelesfajl = saveFileDialog.FileName;


                using (StreamWriter sw = new StreamWriter(rendelesfajl, true))
                {
                    int osszeg = 0;
                    string fizetesimod = "";
                    string szamla = "";

                    if (radioButton_bankkartya.Checked)
                    {
                        fizetesimod = "Bankkártya";
                    }
                    else if (radioButton_kezpenz.Checked)
                    {
                        fizetesimod = "Készpénz";
                    }

                    if (checkBox_szamla.Checked)
                    {
                        szamla = "Kér";
                    }
                    else
                    {
                        szamla = "Nem kér";
                    }

                    sw.WriteLine($"Számlát {szamla}, Fizetési mód: {fizetesimod}");
                    int osszertek = 0;
                    foreach (var item in listBox_kosar.Items)
                    {
                        sw.WriteLine(item);
                        osszertek += int.Parse(textBox_ara.Text);
                    }
                    sw.WriteLine($"Fizetendő összeg: {osszertek} Ft");
                }
            }
            else
            {
                MessageBox.Show("Minden adatot tölts ki!");
            }
        }
    }
}

