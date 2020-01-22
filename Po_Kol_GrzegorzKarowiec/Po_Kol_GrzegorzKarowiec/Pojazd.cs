using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po_Kol_GrzegorzKarowiec
{
    abstract class Pojazd
    {
        public double Masa;
        public string Nazwa;
        public Pojazd(double masa, string nazwa)
        {
            this.Masa = masa;
            this.Nazwa = nazwa;
        }
    }
}
