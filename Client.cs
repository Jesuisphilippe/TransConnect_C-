using System;

namespace TransConnect
{
    internal class Client
    {
        int noSS;
        string nom;
        string prénom;
        DateTime datenaissance;
        string adresse;
        string email;
        string telephone;

        public Client(int noSS, string nom, string prénom, DateTime datenaissance, string adresse, string email, string telephone)
        {
            this.noSS = noSS;
            this.nom = nom;
            this.prénom = prénom;
            this.datenaissance = datenaissance;
            this.adresse = adresse;
            this.email = email;
            this.telephone = telephone;
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
    }
}
