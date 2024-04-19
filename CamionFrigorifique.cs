using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TransConnect
{
    internal class CamionFrigorifique : PoidsLourd
    {
        public bool AGroupesElectrogenes { get; set; } // Indique la présence de groupes électrogènes

        public CamionFrigorifique(int volume, bool aGroupesElectrogenes)
            : base(volume)
        {
            Usage = "Transport de marchandises périssables";
            AGroupesElectrogenes = aGroupesElectrogenes;
        }

        public override double TauxMultiplicateur()
        {
            return 2.0; // Tarif ajusté pour les camions frigorifiques en raison de la nécessité de maintenir un environnement froid
        }
    }
}
