using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TransConnect
{
    internal class Voiture : Vehicule
    {
        public Voiture(int passagers)
            : base(passagers, 0, "Transport de personnes")
        {
        }

        public override double TauxMultiplicateur()
        {
            return 1.1; // Tarif ajusté pour les voitures, par exemple
        }
    }
}
