using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aukcja Piłka = new Aukcja(1, "Uzywana, stan dobry", 50, DateTime.Today);
            Piłka.DodajKlienta(new Klient("Jaś"));
            Piłka.DodajKlienta(new Klient("Małgosia"));
            Piłka.DodajKlienta(new Klient("Wiedźma"));
            Piłka.ZmienCene(80);
            Console.ReadKey();
        }
    }
}
