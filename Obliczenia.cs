using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia3_2
{
    class Obliczenia
    {
        private double liczba1;
        private double liczba2;
        public Obliczenia(double liczba1, double liczba2)
        {
            this.liczba1 = liczba1;
            this.liczba2 = liczba2;
        }
        public double Dodawanie()
        {
            return liczba1 + liczba2;
        }
        public double Odejmowanie()
        {
            return liczba1 - liczba2;
        }
        public double Mnozenie()
        {
            return liczba1 * liczba2;
        }
        public double Dzielenie()
        {
            return liczba1 / liczba2;
        }
        public double Potegowanie()
        {
            return Math.Pow(liczba1, liczba2);
        }
        public double Pierwiastkowanie()
        {
            return Math.Pow(liczba1,1/liczba2);
        }
    }
}
