using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class PowiadomienieCena:Powiadomienie
    {
        double _aukcja;
        public PowiadomienieCena(double a)
        {
            this._aukcja = a;
        }
        public override string GetWiadomosc()
        {
            return "Cena " + _aukcja;

        }
    }
}
