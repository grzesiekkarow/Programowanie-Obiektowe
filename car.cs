using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cwiczenie3
{
    class Car
    {
        private double _pojemnoscSilnika;
        private string _marka;
        private static int _iloscKol;

        private Car()
        {

        }
        private Car(double pojemnoscSilnika, string marka)
        {
            this._pojemnoscSilnika = pojemnoscSilnika;
            this._marka = marka;
        }

        public static Car Create()
        {
            var car = new Car();

            return car;
        }
        static Car()
        {
            _iloscKol = 4;
        }

        ~Car()
        {
            MessageBox.Show("Zwalniam pamiec");
        }
    }
}
