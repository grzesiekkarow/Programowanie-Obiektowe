using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciazona
{
    class osoba
    {
        private string _imie;
        internal string _nazwisko;
        protected int _rokUrodzenia;
        public int waga;
        public double wzrost;
        public bool okulary;
        public enum plec { Kobieta =0 , Mezczyna=1};
        private plec _plec;
        public osoba(string imie, string nazwisko, int rokUrodzenia, plec Plec)
        {
            this._imie = imie;
            this._nazwisko = nazwisko;
            this._rokUrodzenia = rokUrodzenia;
            this._plec = Plec;
        }
        public int obliczWiek()
        {
            int wiek=DateTime.Now.Year-_rokUrodzenia;
            return wiek;
        }
        public void Przedstaw()
        {
            int wiek = obliczWiek();
            string wiekS = wiek.ToString();
            if((int)_plec==1)
                Console.WriteLine("Pan" +" " + _imie + " " + _nazwisko + " " + wiekS);
            else
                Console.WriteLine("Pani" + _imie + " " + _nazwisko + " " + wiekS);
        }
        public double Bmi()
        {
            double wzrotsotos = wzrost / 100;
            double bmi = waga/((wzrost/100)*(wzrost/100));
            return bmi;
        }
    }
    class produkt
    {
        public double _cena;
        private string _nazwa;

        public produkt(string nazwa, double cena)
        {
            this._cena = cena;
            this._nazwa = nazwa;
        }
    }
    class Koszyk
    {
        public List<produkt> listaTowarow = new List<produkt>();
        public void DodajDoKoszyka(produkt nazwa)
        {
            listaTowarow.Add(nazwa);
        }
    }
    class Zespolone
    {
        public int rzeczywista;
        public int urojona;
        public Zespolone(int rzeczywista, int urojona)
        {
            this.rzeczywista = rzeczywista;
            this.urojona = urojona;
        }
        public Zespolone Dodawanie(Zespolone liczba1, Zespolone liczba2)
        {
            Zespolone wynik = new Zespolone(0, 0);
            wynik.rzeczywista = liczba1.rzeczywista + liczba2.rzeczywista;
            wynik.urojona = liczba1.urojona + liczba2.urojona;

            return wynik;
        }
        public Zespolone Odejmowanie(Zespolone liczba1, Zespolone liczba2)
        {
            Zespolone wynik = new Zespolone(0, 0);
            wynik.rzeczywista = liczba1.rzeczywista - liczba2.rzeczywista;
            wynik.urojona = liczba1.urojona - liczba2.urojona;

            return wynik;
        }
        public Zespolone Mnozenie(Zespolone liczba1, Zespolone liczba2)
        {
            Zespolone wynik = new Zespolone(0, 0);
            wynik.rzeczywista = liczba1.rzeczywista * liczba2.rzeczywista - liczba1.urojona*liczba2.urojona ;
            wynik.urojona = liczba1.rzeczywista*liczba2.urojona + liczba1.urojona*liczba2.rzeczywista;

            return wynik;
        }
    }
}
