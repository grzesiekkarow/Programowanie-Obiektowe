using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po_Kol_GrzegorzKarowiec
{
    class Program
    {
        static void Main(string[] args)
        {
            var prom = new Prom(5000);
            var ciezarowy1 = new Ciezarowka(3000, "MAN");
            var ciezarowy2 = new Ciezarowka(2000, "Solaris");
            var osobowy1 = new Osobowy(1000, "BMW");
            var osobowy2 = new Osobowy(700, "Audi");
            prom.ZaladujPojazd(ciezarowy1);
            prom.ZaladujPojazd(ciezarowy2);
            prom.ZaladujPojazd(osobowy1);
            prom.ZaladujPojazd(osobowy2);
            Console.ReadKey();
        }
    }
}
