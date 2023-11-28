using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormPizza
{
    internal class Pizza
    {
        int azon;
        string pizzanev;
        double ar;

        public Pizza(string line)
        {
            string[] sor = line.Split(';');
            azon = int.Parse(sor[0]);
            pizzanev = sor[1].Trim().Replace("\"", string.Empty);
            Ar = double.Parse(sor[2].Trim().Replace("\"", string.Empty).Replace('.', ','));
        }

        public int Azon { get => azon; set => azon = value; }
        public string PizzaNev { get => pizzanev; set => pizzanev = value; }
        public double Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return $"{pizzanev} ára: {ar.ToString("#0 Ft")}";
        }
    }
}

