using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Termek
    {
        public int termekid;
        public string nev;
        public int ar;
        public int db;

        public Termek(int termekid, string nev, int ar, int db)
        {
            this.termekid = termekid;
            this.nev = nev;
            this.ar = ar;
            this.db = db;
        }
        public override string ToString()
        {
            return this.nev;
        }
    }
}
