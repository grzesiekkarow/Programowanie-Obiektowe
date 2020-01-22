using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Firma
    {
        public List<Pracownik> pracownicy = new List<Pracownik>();
        public Dictionary<string, double> PobierzPracownikowZPensjaMniejszaNiz(double p)
        {
            Dictionary<string, double> slownik = new Dictionary<string, double>();
            foreach (var prac in pracownicy)
            {
                if (prac.pensja < p)
                    slownik.Add(prac.pesel, prac.pensja);
            }

            return slownik;
        }
        public void WypiszSlownik(Dictionary<string, double> slownik)
        {
            foreach (var pr in slownik)
            {
                Console.WriteLine(pr.Key + " - " + pr.Value.ToString());
            }
        }
    }
}
