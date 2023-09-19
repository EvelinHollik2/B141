using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hidegburkolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double szel, hossz, magas;
            szel = szamotKer("Add meg a szoba szélességét: ");
            hossz = szamotKer("Add meg a szoba hosszát: ");
            magas = szamotKer("Add meg a szoba magasságát: ");

            double terulet = 2 * (szel + hossz) * magas + szel * hossz;
            double tertizszaz = terulet * 1.10;
            double csomfel = 1.44;
            double szuksegescsom = Math.Ceiling(tertizszaz / csomfel);
            Console.WriteLine($"Szükséges csomagfelület száma: {szuksegescsom} csomag");
            Console.ReadLine();
        }


        private static double szamotKer(string szoveg)
        {
            double bekertSzam;
            Console.Write(szoveg);
            bekertSzam = double.Parse(Console.ReadLine());
            return bekertSzam;
        }

    }
}
