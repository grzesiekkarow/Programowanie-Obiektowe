using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciazona
{
    class program2
    {
        static void Main(string[] args)
        {
            var dyrektor = new osoba("Jan", "Kowalski", 1960,osoba.plec.Mezczyna);
            dyrektor.Przedstaw();
            var pacjent = new osoba("Halina", "Nazwiskowa", 1970, osoba.plec.Kobieta);
            pacjent.waga = 50;
            pacjent.wzrost = 165;
            double bmiPacjenta = pacjent.Bmi();
            if(bmiPacjenta<18.5)
                Console.WriteLine("Pacjent ma niedowage");
            if (bmiPacjenta >= 18.5 & bmiPacjenta < 25)
                Console.WriteLine("Pacjent ma prawidlowa wage");
            if (bmiPacjenta >= 25 & bmiPacjenta < 30)
                Console.WriteLine("Pacjent ma nadwage");
            if (bmiPacjenta >= 30)
                Console.WriteLine("Pacjent jest otyly");
            Console.WriteLine("#####################################################");
            var produkt1 = new produkt("Chleb", 2.50);
            var produkt2 = new produkt("Ser", 8.23);
            var produkt3 = new produkt("Szynka", 10.56);
            var produkt4 = new produkt("Sok", 5.35);
            var koszyk = new Koszyk();
            koszyk.DodajDoKoszyka(produkt1);
            koszyk.DodajDoKoszyka(produkt2);
            koszyk.DodajDoKoszyka(produkt3);
            koszyk.DodajDoKoszyka(produkt4);
            WyswietlZakupy(koszyk);
            Console.WriteLine("#####################################################");
            var zespolona = new Zespolone(2, 4);
            var zespolona2 = new Zespolone(1, 3);
            var dodawanie = zespolona.Dodawanie(zespolona, zespolona2);
            var odejmowanie = zespolona.Odejmowanie(zespolona, zespolona2);
            var mnozenie = zespolona.Mnozenie(zespolona, zespolona2);
            Console.WriteLine("Zespolona 1: " + zespolona.rzeczywista + "+" + zespolona.urojona + "i");
            Console.WriteLine("Zespolona 2: " + zespolona2.rzeczywista + "+" + zespolona2.urojona + "i");
            Console.WriteLine("Dodawanie: " + dodawanie.rzeczywista + "+" + dodawanie.urojona + "i");
            Console.WriteLine("Odejmowanie: " + odejmowanie.rzeczywista + "+" + odejmowanie.urojona + "i");
            Console.WriteLine("Mnozenie: " + mnozenie.rzeczywista + "+" + mnozenie.urojona + "i");
            Console.ReadKey();
        }


        static void WyswietlZakupy(Koszyk koszyk)
        {
            Console.WriteLine("Ilosc zakupow w koszyku: " + koszyk.listaTowarow.Count);
            double suma = 0;
            for (int i = 0; i < koszyk.listaTowarow.Count; i++)
            {
                suma += koszyk.listaTowarow[i]._cena;
            }
            Console.WriteLine("Calkowita suma cen: " + suma);


        }




        static string opiszTyp(string b)
        {
            return b;
        }
        static int opiszTyp(int a, int b)
        {
            return a + b;
        }
        static double opiszTyp(double a, int b, double c)
        {
            return (a + b) / c;

        }
    }
}
