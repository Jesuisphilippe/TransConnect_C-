using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TransConnect
{
    internal class Chauffeur : Salarie
    {
        public DateTime DateDerniereLivraison { get; set; }
        public bool Libre { get; set; }

        public Chauffeur(int noSS, string nom, string prénom, DateTime dateNaissance, string adresse, string email, string telephone, DateTime dateEntree, string poste, int salaire, DateTime dateDerniereLivraison, bool libre)
            : base(noSS, nom, prénom, dateNaissance, adresse, email, telephone, dateEntree, poste, salaire)
        {
            DateDerniereLivraison = dateDerniereLivraison;
            Libre = libre;
        }

        public void MettreAJourDisponibilite(DateTime date, bool estLibre)
        {
            DateDerniereLivraison = date;
            Libre = estLibre;
        }
    }
}
