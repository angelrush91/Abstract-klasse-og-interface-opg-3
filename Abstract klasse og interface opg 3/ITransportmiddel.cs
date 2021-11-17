using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_klasse_og_interface_opg_3
{
    interface ITransportmiddel
    {
        //oprettelse af interface metoder, husk variablerne i metoden eks: int a, da det skal retunere noget
        bool Fuel(int a);
        //Kør() behøver ikke noget da det er en void og ikke returnere noget.
        void Kør();
    }
}
