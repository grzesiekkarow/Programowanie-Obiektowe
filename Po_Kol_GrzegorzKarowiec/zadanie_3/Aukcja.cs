using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Aukcja
    {
        List<IObserver> ListaKlientow = new List<IObserver>();
        public int id;
        public string opis;
        public double cena;
        public DateTime dataZakonczenia;
        public Aukcja(int i, string o, double c, DateTime d)
        {
            this.id = i;
            this.opis = o;
            this.cena = c;
            this.dataZakonczenia = d;
        }
        public void DodajKlienta(Klient kl)
        {
            ListaKlientow.Add(kl);
        }
        public void ZmienCene(double c)
        {
            this.cena = c;
            Powiadomienie(new PowiadomienieCena(cena));
        }
        public void ZmienDate(DateTime d)
        {
            this.dataZakonczenia = d;
            Powiadomienie(new PowiadomienieDataZakonczenia(dataZakonczenia));
        }
        public void ZmienOpis(string o)
        {
            this.opis = o;
            Powiadomienie(new PowiadomienieOpis(opis));
        }

        void Powiadomienie(Powiadomienie pow)
        {
            foreach (var klient in ListaKlientow)
            {
                klient.Update(pow);
            }
        }
    }
}
