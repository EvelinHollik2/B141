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
            //két szám bekérése és összeadása
            int szamA, szamB; //deklarálás

            Console.WriteLine("Adj meg egy számot: ");
            szamA =int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy másik számot: ");
            szamB = int.Parse(Console.ReadLine());

            Console.WriteLine("A két szám összege: " +(szamA + szamB).ToString());
            Console.ReadLine();
        }
    }
}
