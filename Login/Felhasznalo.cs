using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Felhasznalo
    {
        private int vasarloid;
        private string nev;
        private int jelszo;

        public Felhasznalo(int vasarloid, string nev, int jelszo)
        {
            this.vasarloid = vasarloid;
            this.nev = nev;
            this.jelszo = jelszo;
        }

        public int Vasarloid { get => vasarloid; set => vasarloid = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Jelszo { get => jelszo; set => jelszo = value; }
    
        public override string ToString()
        {
            return this.nev;
        }
    }
}
