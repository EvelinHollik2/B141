using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--két szám bekérése és összeadása
            int szamA, szamB; //deklarálás

            //Console.Write("Adj meg egy számot: ");
            //--bekérek egy számot
            //szamA =int.Parse(Console.ReadLine());
            szamA = szamotKer("Adj meg egy számot: ");

            //Console.Write("Adj meg egy másik számot: ");
            //--bekérek még egy számot
            //szamB = int.Parse(Console.ReadLine());
            szamB = szamotKer("Adj meg egy másik számot: ");


            Console.WriteLine("A két szám összege: " +(szamA + szamB).ToString());
            Console.ReadLine();

        }

        private static int szamotKer(string szoveg)
        {
            int bekertSzam;
            Console.Write(szoveg);
            bekertSzam = int.Parse(Console.ReadLine());
            return bekertSzam;
        }
    }
}
