using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_OrarendNyilvantartas
{
    internal class Orarend
    {
        private int oraid;
        private string tantargy;
        private int sorszam;
        private string hetnapja;

        public Orarend(int oraid, string tantargy, int sorszam, string hetnapja)
        {
            this.oraid = oraid;
            this.tantargy = tantargy;
            this.sorszam = sorszam;
            this.hetnapja = hetnapja;
        }

        public int Oraid { get => oraid; set => oraid = value; }
        public string Tantargy { get => tantargy; set => tantargy = value; }
        public int Sorszam { get => sorszam; set => sorszam = value; }
        public string Hetnapja { get => hetnapja; set => hetnapja = value; }

        public override string ToString()
        {
            return this.tantargy;
        }
    }
}
