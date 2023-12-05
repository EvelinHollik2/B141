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

namespace WindowsFormsApp_OrarendNyilvantartas
{
    public partial class Form_Orarend : Form
    {
        public Form_Orarend()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        //Program.command.CommandText = "SELECT `tantargy` FROM `orak` WHERE `hetnapja` = Hétfő;";

        private void Form_Orarend_Load(object sender, EventArgs e)
        {
            Betoltes();
        }

        private void Betoltes()
        {
            Hetfo.Items.Clear();
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                Program.command.CommandText = "SELECT `oraid`,`sorszam`,`tantargy` FROM `orak` WHERE `hetnapja` = \"hétfő\";";
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Orarend beolvasottTermek = new Orarend(dr.GetInt32("oraid"), dr.GetString("tantargy"), dr.GetInt32("sorszam"), dr.GetString("hetnapja"));
                        Hetfo.Items.Add(beolvasottTermek);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //hibakód
                Environment.Exit(0);
            }
        }

        private void Hetfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orarend Rendeles = (Orarend)Hetfo.SelectedItem;
            Hetfo.Text = Rendeles.Tantargy;
        }
    }
}
