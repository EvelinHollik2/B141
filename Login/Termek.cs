using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Termek
    {
        private int termekid;
        private string termeknev;
        private int ar;
        private int db;

        public int Termekid { get => termekid; set => termekid = value; }
        public string Termeknev { get => termeknev; set => termeknev = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Db { get => db; set => db = value; }

        public Termek(int termekid, string nev, int ar, int db)
        {
            this.termekid = termekid;
            this.termeknev = nev;
            this.ar = ar;
            this.db = db;
        }
        public override string ToString()
        {
            return this.termeknev;
        }
    }
}
