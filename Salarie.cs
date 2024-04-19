using System;

namespace TransConnect
{
    internal class Salarie : Personne
    {
        public DateTime DateEntree { get; private set; }
        public string Poste { get; set; }
        public int Salaire { get; set; }

        public Salarie(int noSS, string nom, string prénom, DateTime dateNaissance, string adresse, string email, string telephone, DateTime dateEntree, string poste, int salaire)
            : base(noSS, nom, prénom, dateNaissance, adresse, email, telephone)
        {
            DateEntree = dateEntree;
            Poste = poste;
            Salaire = salaire;
        }
    }
}
