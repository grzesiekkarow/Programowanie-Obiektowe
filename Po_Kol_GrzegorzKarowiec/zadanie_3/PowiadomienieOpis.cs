using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class PowiadomienieOpis:Powiadomienie
    {
        string _aukcja;
        public PowiadomienieOpis(string aukcja)
        {
            this._aukcja = aukcja;
        }

        public override string GetWiadomosc()
        {
            return _aukcja;

        }
    }
}
