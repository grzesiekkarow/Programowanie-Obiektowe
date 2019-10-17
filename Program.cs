using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carName = "Mój samochód";
            Console.WriteLine(carName);
            var car1 = new Car("Volvo",2017);
            car1.Wyswietl();
            var car2 = new Car("BMW", 1996);
            car2.Wyswietl();
            /*car1 = car2;
            car1.Wyswietl();*/
            
            Console.ReadKey();
        }
    }
}
