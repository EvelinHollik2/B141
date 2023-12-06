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

        private void Form_Orarend_Load(object sender, EventArgs e)
        {
            updateOrakLista();
        }

        private void updateOrakLista()
        {
            Hetfo.Items.Clear();
            Hetfo.Items.AddRange(Program.db.getNapiOrarend("hétfő").ToArray());
            Kedd.Items.Clear();
            Kedd.Items.AddRange(Program.db.getNapiOrarend("kedd").ToArray());
            Szerda.Items.Clear();
            Szerda.Items.AddRange(Program.db.getNapiOrarend("szerda").ToArray());
            Csutortok.Items.Clear();
            Csutortok.Items.AddRange(Program.db.getNapiOrarend("csütörtök").ToArray());
            Pentek.Items.Clear();
            Pentek.Items.AddRange(Program.db.getNapiOrarend("péntek").ToArray());
        }

        private void Hetfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Hetfo.SelectedIndex < 0)
            {
                return;
            }
            Orarend kivalasztottOra = (Orarend)Hetfo.SelectedItem;
        }

        private void Kedd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Kedd.SelectedIndex < 0)
            {
                return;
            }
            Orarend kivalasztottOra = (Orarend)Kedd.SelectedItem;
        }

        private void Szerda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Szerda.SelectedIndex < 0)
            {
                return;
            }
            Orarend kivalasztottOra = (Orarend)Szerda.SelectedItem;
        }

        private void Csutortok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Csutortok.SelectedIndex < 0)
            {
                return;
            }
            Orarend kivalasztottOra = (Orarend)Csutortok.SelectedItem;
        }

        private void Pentek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pentek.SelectedIndex < 0)
            {
                return;
            }
            Orarend kivalasztottOra = (Orarend)Pentek.SelectedItem;
        }
    }
}
