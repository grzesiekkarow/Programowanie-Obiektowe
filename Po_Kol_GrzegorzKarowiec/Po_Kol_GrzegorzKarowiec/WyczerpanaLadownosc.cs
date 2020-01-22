using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po_Kol_GrzegorzKarowiec
{
    class WyczerpanaLadownosc:Exception
    {
        public WyczerpanaLadownosc(string message):base(message)
        {
            
        }
    }
}
