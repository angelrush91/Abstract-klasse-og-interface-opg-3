using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_3
{
    internal class Bil : ITransportmiddel
    {
        
        private int Brændstof;

        public Bil()
        {
        }

        public Bil(string Kør, int Brændstof)
        {
            
            this.Brændstof = Brændstof;

        }

        public int getsetBrændstof
        {
            get { return Brændstof; }
            set { Brændstof = value; }
        }


        public bool Fuel(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else
                return false;

        }
        public void Kør()
        {
            Console.WriteLine("bilen kører");
        }
    }
}
