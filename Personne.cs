using System;

namespace TransConnect
{
    internal abstract class Personne
    {
        public int NoSS { get; private set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public DateTime DateNaissance { get; private set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        protected Personne(int noSS, string nom, string prénom, DateTime dateNaissance, string adresse, string email, string telephone)
        {
            NoSS = noSS;
            Nom = nom;
            Prénom = prénom;
            DateNaissance = dateNaissance;
            Adresse = adresse;
            Email = email;
            Telephone = telephone;
        }
    }
}
