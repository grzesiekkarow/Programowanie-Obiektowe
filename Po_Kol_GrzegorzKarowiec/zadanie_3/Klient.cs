using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Klient:IObserver
    {
        string nazwa;
        public Klient(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public void Update(Powiadomienie pow)
        {
            Console.WriteLine(pow.GetWiadomosc());
        }
    }
}
