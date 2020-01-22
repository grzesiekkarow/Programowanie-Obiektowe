using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po_Kol_GrzegorzKarowiec
{
    class Prom
    {
        private double ladownosc;
        private double masaPojazdow;
        private List<Pojazd> pojazdy = new List<Pojazd>();
        private bool zaladowany = false;
        public Prom(double ladownosc)
        {
            this.ladownosc = ladownosc;
        }
        public double MasaZaladowanychPojazdow()
        {
            return masaPojazdow;
        }
        public void WyladujPojazd(Pojazd p)
        {
            pojazdy.Remove(p);
            masaPojazdow -= p.Masa;
        }
        public void ZaladujPojazd(Pojazd p)
        {
            try
            {
                if (masaPojazdow + p.Masa < ladownosc)
                {
                    masaPojazdow += p.Masa;
                    pojazdy.Add(p);
                }
                else
                {
                    zaladowany = true;
                    throw (new WyczerpanaLadownosc("Ladownosc zostanie przekroczona"));
                    
                }
            }
            catch(WyczerpanaLadownosc e)
            {
                throw;
            }
            
            
            
        }
    }
}
