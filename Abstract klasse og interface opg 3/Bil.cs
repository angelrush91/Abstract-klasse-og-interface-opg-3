﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_3
{
    internal class Bil : ITransportmiddel
    {
        private string Kør;
        private bool Brændstof;

        public Bil(string Kør, bool Brændstof)
        {
            this.Kør = Kør;
            this.Brændstof = Brændstof;

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