using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_3
{
    internal class Bil : ITransportmiddel//Bil med interface
    {
        //Fields
        private int Brændstof;
        //konstructor, den foreslog selv dette så det fik den lov til at lave
        public Bil()
        {
        }
        //min konstructor som jeg selv har lavet
        public Bil(string Kør, int Brændstof)
        {
            
            this.Brændstof = Brændstof;

        }
        // min get set for brændstof
        public int getsetBrændstof
        {
            get { return Brændstof; }
            set { Brændstof = value; }
        }

        //min interface metode af fuel
        public bool Fuel(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else
                return false;

        }
        // min kør metodet fra mit interface
        public void Kør()
        {
            Console.WriteLine("bilen kører");
        }
    }
}
