using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_3
{
    internal class Bil : ITransportmiddel
    {
        private string Kør;
        private bool Fuel;
        Bil.Fuel = false;
        
        public Bil(string Kør, bool Fuel)
        {
            this.Kør = Kør;
            this.Fuel = Fuel;

        }

        public static bool Fuel()
        {
            if (Brændstof)
            {
                Console.WriteLine("den kan køre");
            }   
        }
    }
}
