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
            openFileDialog1.FileName = "pizza.csv";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_pizza.Items.Add(new Pizza(sr.ReadLine()));
                    }
                }
            }
        }

        private void button_betoltes_Click(object sender, EventArgs e)
        {
            Adatbetoltes(openFileDialog1.FileName);
        }
    }
}
