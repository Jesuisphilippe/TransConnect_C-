using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect
{
    internal class PoidsLourd : Vehicule
    {
        public PoidsLourd(int volume)
            : base(0, volume, "Transport de marchandises lourdes")
        {
        }

        public override double TauxMultiplicateur()
        {
            return 1.5; // Tarif ajusté pour les poids lourds
        }
    }
}
