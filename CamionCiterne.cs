using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect
{
    internal class CamionCiterne : PoidsLourd
    {
        public string TypeCuve { get; set; }

        public CamionCiterne(int volume, string typeCuve)
            : base(volume)
        {
            Usage = "Transport de liquides ou produits gazeux";
            TypeCuve = typeCuve;
        }

        public override double TauxMultiplicateur()
        {
            return 1.8; // Tarif ajusté pour les camions-citerne en raison de la spécialisation
        }
    }
}
