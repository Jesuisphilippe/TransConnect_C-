using System;

namespace TransConnect
{
    internal class Vehicule
    {
        public int Passagers { get; protected set; }
        public int Volume { get; protected set; }
        public string Usage { get; protected set; }

        public Vehicule(int passagers, int volume, string usage)
        {
            Passagers = passagers;
            Volume = volume;
            Usage = usage;
        }

        public virtual double TauxMultiplicateur()
        {
            // Cette méthode pourrait être utilisée pour ajuster le tarif dans la classe Commande
            return 1.0;
        }
    }
}
