using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class PowiadomienieDataZakonczenia:Powiadomienie
    {
        DateTime _aukcja;
        public PowiadomienieDataZakonczenia(DateTime a)
        {
            this._aukcja = a;
        }
        public override string GetWiadomosc()
        {
            return "Data zakonczenia " + _aukcja;

        }
    }
}
