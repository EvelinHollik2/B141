using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace euroskill2025
{

    /*
    a backend letöltése (CSV szerver telepítése):
    npm i -g json-server
    Szerver letöltése (Adatbázis indítása):
    json-server database.json
     */
    public partial class Form1 : Form
    {
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {            
            client = new HttpClient();
            listBox_Containers.DisplayMember = "id";
            listBox_Containers.Sorted = true;

            // -- Kontainer lista beröltése
            await kontenerListaFrissitese();
        }

        private async Task kontenerListaFrissitese()
        {
            listBox_Containers.Items.Clear();
            string urlContainers = "http://localhost:3000/containers";
            try
            {
                HttpResponseMessage response = await client.GetAsync(urlContainers);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JArray containers = (JArray)Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                    listBox_Containers.Items.AddRange(containers.ToObject<Container[]>());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
                
            }

        }
    }
}
