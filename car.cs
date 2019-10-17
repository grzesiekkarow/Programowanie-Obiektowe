using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2
{
    class Car
    {
        private string _marka;
        private int _rok;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public Car(string marka, int rok)
        {
            this._marka = marka;
            this._rok = rok;
        }

        public void Wyswietl()
        {
            string rokS = _rok.ToString();
            Console.WriteLine(_marka + " " + rokS);
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = srednieSpalanie * dlugoscTrasy;
            return spalanie;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {

            double spalanie = ObliczSpalanie(dlugoscTrasy);
            double kosztPrzejazdu = spalanie * cenaPaliwa;
            return kosztPrzejazdu;
        }
    }
}
