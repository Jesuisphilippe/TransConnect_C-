using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect
{
    internal class CamionBenne : PoidsLourd
    {
        public int NombreBennes { get; set; }
        public bool AGrue { get; set; } // Indique si une grue est installée

        public CamionBenne(int volume, int nombreBennes, bool aGrue)
            : base(volume)
        {
            Usage = "Travaux publics ou voirie";
            NombreBennes = nombreBennes;
            AGrue = aGrue;
        }

        public override double TauxMultiplicateur()
        {
            return 1.6; // Tarif ajusté pour les camions benne
        }
    }
}
