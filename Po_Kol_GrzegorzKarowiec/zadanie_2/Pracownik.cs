using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Pracownik
    {
        public string imie;
        public string nazwisko;
        public string pesel;
        public double pensja;
        public int wiek;
        public Pracownik(string imie, string nazwisko, string pesel, double pensja, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.pensja = pensja;
            this.wiek = wiek;
        }
    }
}
