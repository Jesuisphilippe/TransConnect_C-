using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TransConnect
{
    internal class Camionnette : Vehicule
    {
        public Camionnette(string usage)
            : base(0, 0, usage)
        {
        }

        public override double TauxMultiplicateur()
        {
            return 1.2; // Tarif ajusté pour les camionnettes
        }
    }
}
