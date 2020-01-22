using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pracownik1 = new Pracownik("Jan", "Kowalski", "80030200860", 5000, 40);
            var pracownik2 = new Pracownik("Agata", "Pszczoła", "90021702566", 10000, 30);
            var pracownik3 = new Pracownik("Tomasz", "Chciał", "75121212122", 3000, 45);
            var pracownik4 = new Pracownik("Anna", "Niechciała", "85060688888", 4000, 35);
            var pracownik5 = new Pracownik("Pan", "Hilary", "60040876543", 15000, 60);
            var firma = new Firma();
            firma.pracownicy.Add(pracownik1);
            firma.pracownicy.Add(pracownik2);
            firma.pracownicy.Add(pracownik3);
            firma.pracownicy.Add(pracownik4);
            firma.pracownicy.Add(pracownik5);
            Dictionary<string, double> pracownicy = firma.PobierzPracownikowZPensjaMniejszaNiz(10000);
            firma.WypiszSlownik(pracownicy);
            Console.ReadKey();
        }

    }
}
