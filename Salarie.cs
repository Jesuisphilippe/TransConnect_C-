using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnect
{
    internal class Salarie
    {
        int noSS;
        DateTime datenaissance;
        string prénom;
        string nom;
        string adresse;
        string email;
        string telephone;
        DateTime date_entree;
        string poste;
        int salaire;

        public Salarie(int noSS, DateTime datenaissance, string prénom, string nom, string adresse, string email, string telephone, DateTime date_entree, string poste, int salaire)
        {
            this.noSS = noSS;
            this.datenaissance = datenaissance;
            this.prénom = prénom;
            this.nom = nom;
            this.adresse = adresse;
            this.email = email;
            this.telephone = telephone;
            this.date_entree = date_entree;
            this.poste = poste;
            this.salaire = salaire;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }

        public int Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
    }
}
